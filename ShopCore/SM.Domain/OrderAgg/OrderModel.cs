using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SM.Domain.OrderAgg
{
    public class OrderModel
    {
        protected OrderModel() { }
        public OrderModel(long userId, double totalPrice,  double discountAmount, double payAmount)
        {
            UserId = userId;
            TotalPrice = totalPrice;
            DiscountAmount = discountAmount;
            PayAmount = payAmount;
            this.orderDetails = new List<OrderDetailModel>();
            IsCanceled = false;
            IsFinaly = false;
            RefId = 0;
        }
        public void Add(OrderDetailModel orders)
        {
            orderDetails.Add(orders);
        }
        public void PaymentSuccedde(long refid)
        {
            IsFinaly = true;
            if (refid > 0)
                RefId = refid;
        }
        public void SetCode(string code) => Code = code;
        public void Cancel() => IsCanceled = true;

        public long Id { get; private set; }
        public long UserId { get; private set; }
       
        public double TotalPrice { get; private set; }
        public double DiscountAmount { get; private set; }
        public double PayAmount { get; private set; }
        public bool IsFinaly { get; private set; }
        public bool IsCanceled { get; private set; }
        public string Code { get; private set; }
        public long RefId { get; private set; }
        public List<OrderDetailModel> orderDetails { get; private set; }

    }

}
