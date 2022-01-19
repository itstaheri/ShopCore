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
        public OrderModel(long userId, double totalPrice
            , double discountAmount, double payAmount, int paymentMethod, string customerDescription)
        {
            UserId = userId;
            TotalPrice = totalPrice;
            DiscountAmount = discountAmount;
            PayAmount = payAmount;
            this.orderDetails = new List<OrderDetailModel>();
            IsFinaly = false;
            RefId = 0;
            PaymentMethod = paymentMethod;
            CustomerDescription = customerDescription;
            OrderDate = DateTime.Now;
            Status = 4;
        }
        public void Add(OrderDetailModel orders)
        {
            orderDetails.Add(orders);
        }
        public void PaymentSuccedde(long refid)
        {
            Status = 1;
            IsFinaly = true;
            if (refid > 0)
                RefId = refid;
        }

        public void Pending_status() => Status = 1;
        public void Sended_status() => Status = 2;
        public void Suspended_status() => Status =4;



        public void SetCode(string code) => Code = code;
      

        public long Id { get; private set; }
        public long UserId { get; private set; }
        public int PaymentMethod { get; private set; }
        public string CustomerDescription { get; private set; }
        public double TotalPrice { get; private set; }
        public double DiscountAmount { get; private set; }
        public double PayAmount { get; private set; }
        public int Status { get; private set; }
        public bool IsFinaly { get; private set; }
        public string Code { get; private set; }
        public long RefId { get; private set; }
        public List<OrderDetailModel> orderDetails { get; private set; }
        public DateTime OrderDate { get; private set; }

    }

}
