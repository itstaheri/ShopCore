using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application;
using Frameworks;
using Frameworks.ZarinPal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using Query.Contract.Cart;
using Query.Contract.Product;
using SM.Application;
using SM.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    [Authorize]
    public class CheckoutModel : PageModel
    {
        PaymentResultMassage Result = new PaymentResultMassage();
        public Cart cart;
        public double totalPrice;
        public const string CookieName = "cart-items";
        private readonly ICartCalculator _cartCalculator;
        private readonly ICartService _cartService;
        private readonly IProductQueryRepository _product;
        private readonly IZarinPalFactory _zarinpal;
        private readonly IOrderApplication _order;
        private readonly IAuthHelper _auth;
        public CheckoutModel(IAuthHelper auth,ICartCalculator cartCalculator, ICartService cartService, IProductQueryRepository product, IZarinPalFactory zarinpal, IOrderApplication order)
        {
            _cartCalculator = cartCalculator;
            _cartService = cartService;
            _product = product;
            _zarinpal = zarinpal;
            _order = order;
            _auth = auth;
        }
        public RedirectToPageResult CartIsNull()
        {
            return RedirectToPage("./Cart");
        }
        public void OnGet()
        {
            var serlializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serlializer.Deserialize<List<CartItem>>(value);
            if (cartItems == null || cartItems.Count == 0)
            {
                CartIsNull();
            }
      
            if (cartItems != null)
            {
                cartItems.ForEach(x => x.TotalPrice = x.UnitPrice * x.Count);
                totalPrice = cartItems.Sum(x => x.TotalPrice);

                cart = _cartCalculator.ComputeCart(cartItems);
                _cartService.Set(cart);
            }

        }
        public IActionResult OnPostPay(int PaymentMethod,string customerDescription)
        {
            cart = _cartService.Get();
           var result = _product.CheckInventory(cart.cartItems);
            cart.PaymentMethod = PaymentMethod;
            cart.CustomerDescription = customerDescription;
            if (result.Any(x => x.IsInStock == false)) return RedirectToPage("./Cart");

            var orderId = _order.PlaceOrder(cart);
            var UserData = _auth.CurrentAccountInfo();
            if (cart.PaymentMethod == 2)
            {
                var Code = _order.PaymentSucceeded(orderId, 0);
                Response.Cookies.Delete("cart-items");
                return RedirectToPage("./PaymentResult",Result.Succeeded("سفارش شما با موفقیت ثبت شد ، منتظر تماس از طرف کارشناسان ما باشید.",null));
            }
            var paymentResponse =_zarinpal.CreatePaymentRequest(cart.PayAmount.ToString(), UserData.Number, UserData.Email, "موبایل", orderId);
            return Redirect($"https://{_zarinpal.Prefix}.zarinpal.com/pg/StartPay/{paymentResponse.Authority}");
        }
        public IActionResult OnGetCallBack([FromQuery] string authority,[FromQuery] string status,[FromQuery] long oId)
        {
           
            var orderAmount = _order.GetAmountBy(oId);
           var verify=  _zarinpal.CreateVerificationRequest(authority, orderAmount.ToString());
            if (status == "OK" && verify.Status >= 100)
            {
               
               var Code = _order.PaymentSucceeded(oId, verify.RefID);
                Response.Cookies.Delete("cart-items");
               return RedirectToPage("./PaymentResult",Result.Succeeded("پرداخت با موفقیت انجام شد.",Code));
            }
            else
            {
               return RedirectToPage("./PaymentResult", Result.Faild("پرداخت با مشکل مواجه شد.در صورت کسر وجه از حساب شما مبلغ کسر شده تا 24آینده به حساب شما برگشت داده خواهد شد"));
            }
        }
    }
}
