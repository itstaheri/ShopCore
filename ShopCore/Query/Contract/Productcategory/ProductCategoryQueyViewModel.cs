using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Productcategory
{
   public class ProductCategoryQueyViewModel
    {
        public long Id { get; set; }
        public string CategoryName { get;  set; }
        public string Slug { get;  set; }
    }
}
