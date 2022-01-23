using System.Collections.Generic;

namespace Query.Contract.Account
{
    public class OrderQueryViewModel
    {
        public long Id { get; set; }
        public double PayAmount { get; set; }
        public string Date { get; set; }
        public int Status { get; set; }
        public int PayMethod { get; set; }
        public string Code { get; set; }
        public List<OrderDetailQueryViewModel> orderDetails { get; set; }
    }
}