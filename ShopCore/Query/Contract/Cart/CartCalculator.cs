using DM.infrastructure.Efcore;
using Frameworks;
using SM.Application.Contracts.Order;
using SM.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Query.Contract.Cart
{
    public class CartCalculator : ICartCalculator
    {
        private readonly ShopContext _shopContext;
        private readonly DiscountContext _discountContext;
        private readonly IAuthHelper _authHelper;

        public CartCalculator(ShopContext shopContext, DiscountContext discountContext, IAuthHelper authHelper)
        {
            _shopContext = shopContext;
            _discountContext = discountContext;
            _authHelper = authHelper;
        }

        public SM.Application.Contracts.Order.Cart ComputeCart(List<CartItem> cartItems)
        {
            var colleagueDiscounts = _discountContext.colleagueDiscounts.Where(x => x.IsRemoved == false)
                .Select(x => new { x.DiscountRate, x.ProductId }).ToList();
            var customerDiscounts = _discountContext.customerDiscounts.Where(x => x.Start < DateTime.Now && x.End > DateTime.Now)
              .Select(x => new { x.DiscountRate, x.ProductId }).ToList();

            var result = new SM.Application.Contracts.Order.Cart();
            var currentAccount = _authHelper.CurrentAccountRole();

            foreach (var item in cartItems)
            {
                if (currentAccount == "4")
                {
                    var colleagueDiscount = colleagueDiscounts.FirstOrDefault(x => x.ProductId == item.Id);
                    if (colleagueDiscount != null)
                        item.DiscountRate = colleagueDiscount.DiscountRate;
                }
                else
                {
                    var customerDiscount = colleagueDiscounts.FirstOrDefault(x => x.ProductId == item.Id);
                    if (customerDiscount != null)
                        item.DiscountRate = customerDiscount.DiscountRate;
                }

                item.DiscountAmount = ((item.TotalPrice * item.DiscountRate) / 100);
                item.ItemPayAmount = item.TotalPrice - item.DiscountAmount;

                result.Add(item);
            }
            return result;
        }
    }
}
