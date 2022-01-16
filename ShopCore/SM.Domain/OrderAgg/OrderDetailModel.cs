using SM.Domain.Product;

namespace SM.Domain.OrderAgg
{
    public class OrderDetailModel
    {
        public OrderDetailModel(int discountRate, int count, double unitPrice, int productId)
        {
            DiscountRate = discountRate;
            Count = count;
            UnitPrice = unitPrice;
            ProductId = productId;
        }

        public long Id { get;private set; }
        public int DiscountRate { get;private set; }
        public int Count { get;private set; }
        public double UnitPrice { get;private set; }

        public long OrderId { get;private set; }
        public OrderModel order { get;private set; }

        public int ProductId { get; private set; }
        public  ProductModel product { get; private set; }
    }
}