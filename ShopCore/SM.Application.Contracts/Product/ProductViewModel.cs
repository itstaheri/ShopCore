using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.Product
{
    public class ProductViewModel
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public long QuantityInStock { get; set; }
        public double Price { get; set; }
        public string CategoryName { get; set; }
        public string CreationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
