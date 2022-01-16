using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.Application;
using Frameworks;
using Frameworks.ZarinPal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using Query.Contract.Cart;
using Query.Contract.Product;
using SM.Application;
using SM.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    public class CheckoutModel : PageModel
    {
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

        public void OnGet()
        {
            var serlializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serlializer.Deserialize<List<CartItem>>(value);
            if (cartItems != null)
            {
                cartItems.ForEach(x => x.TotalPrice = x.UnitPrice * x.Count);
                totalPrice = cartItems.Sum(x => x.TotalPrice);

                cart = _cartCalculator.ComputeCart(cartItems);
                _cartService.Set(cart);
            }

        }
        public IActionResult OnGetPay()
        {
            cart = _cartService.Get();
           var result = _product.CheckInventory(cart.cartItems);

            if (result.Any(x => x.IsInStock == false)) return RedirectToPage("./Cart");

            var orderId = _order.PlaceOrder(cart);
            var UserData = _auth.CurrentAccountInfo();
            _zarinpal.CreatePaymentRequest(cart.PayAmount.ToString(), UserData.Number, UserData.Email, "موبایل", orderId);

            return RedirectToPage("");
        }
    }
}
