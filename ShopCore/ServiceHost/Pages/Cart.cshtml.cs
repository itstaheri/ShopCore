using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using Query.Contract.Product;
using SM.Application.Contracts.Order;
using Frameworks;

namespace ServiceHost.Pages
{
    public class CartModel : PageModel
    {
        public double totalPrice;
        public const string CookieName = "cart-items";
        public List<CartItem> cartItems;
        private readonly IProductQueryRepository _repository;

        public CartModel(IProductQueryRepository repository)
        {
         
            _repository = repository;
        }

        public void OnGet()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            cartItems = serializer.Deserialize<List<CartItem>>(value);

            if (cartItems != null)
            {
                cartItems.ForEach(x => x.TotalPrice = x.UnitPrice * x.Count);
                totalPrice = cartItems.Sum(x => x.TotalPrice);
            }

            cartItems = _repository.CheckInventory(cartItems);

        }
        public RedirectToPageResult OnGetRemove(long Id)
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            Response.Cookies.Delete(CookieName);
            var cartitems = serializer.Deserialize<List<CartItem>>(value);
            var itemtoremoved = cartitems.FirstOrDefault(x => x.Id == Id);
            cartitems.Remove(itemtoremoved);

            var cookieOptions = new CookieOptions { Expires = DateTime.Now.AddDays(2) };
            Response.Cookies.Append(CookieName, serializer.Serialize(cartitems), cookieOptions);

            return RedirectToPage("./Cart");

        }
        public RedirectToPageResult OnGetGoToCheckOut()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            cartItems = serializer.Deserialize<List<CartItem>>(value);
            foreach (var item in cartItems)
            {
                item.TotalPrice = item.UnitPrice * item.Count;

            }
            cartItems = _repository.CheckInventory(cartItems);
            return cartItems.Any(x=>!x.IsInStock) ? RedirectToPage() : RedirectToPage("/Checkout");
        }
    }
}
