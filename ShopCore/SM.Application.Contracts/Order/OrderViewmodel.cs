using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.Order
{
    public class OrderViewmodel
    {
        public long Id { get;  set; }
        public string Username { get;  set; }
        public long UserId { get;  set; }
        public int PaymentMethod { get;  set; }
        public string CustomerDescription { get;  set; }
        public double PayAmount { get;  set; }
        public int Status { get;  set; }
        public bool IsFinaly { get;  set; }
        public string Code { get;  set; }
        public DateTime OrderDate { get;  set; }
        public List<CartItem> cartItems { get; set; }
    }
}
