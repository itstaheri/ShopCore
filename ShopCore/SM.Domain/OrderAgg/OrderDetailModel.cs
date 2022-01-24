using SM.Domain.Product;

namespace SM.Domain.OrderAgg
{
    public class OrderDetailModel
    {
        protected OrderDetailModel() { }
        public OrderDetailModel(int discountRate, int count, double unitPrice, long productId)
        {
            DiscountRate = discountRate;
            Count = count;
            UnitPrice = unitPrice;
            ProductId = productId;
            TotalPrice = unitPrice*count;
        }

        public long Id { get;private set; }
        public int DiscountRate { get;private set; }
        public int Count { get;private set; }
        public double UnitPrice { get;private set; }
        public double TotalPrice { get;private set; }

        public long OrderId { get;private set; }
        public OrderModel order { get;private set; }

        public long ProductId { get; private set; }
       // public  ProductModel product { get; private set; }
    }
}