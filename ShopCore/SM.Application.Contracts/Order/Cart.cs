using System.Collections.Generic;

namespace SM.Application.Contracts.Order
{
    public class Cart
    {
        public List<CartItem> cartItems { get; set; }
        public double TotalAmount { get; set; }
        public double DiscountAmount { get; set; }
        public double PayAmount { get; set; }
        public int PaymentMethod { get;  set; }
        public string CustomerDescription { get; set; }

        public Cart()
        {
            cartItems = new List<CartItem>();
        }
        public void Add(CartItem cartitem)
        {
            cartItems.Add(cartitem);
            TotalAmount += cartitem.TotalPrice;
            DiscountAmount += cartitem.DiscountAmount;
            PayAmount += cartitem.ItemPayAmount;
        }
        public void SetPaymentMethod(int methodId)
        {
            PaymentMethod = methodId;
        }
    }
}
