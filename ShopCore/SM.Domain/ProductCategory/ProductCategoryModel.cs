using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.ProductCategory
{
    public class ProductCategoryModel
    {
        public long Id { get; private set; }
        public string CategoryName { get; private set; }
        public DateTime CreationDate { get; private set; }
        public string Slug { get; private set; }
        //public List<ProductModel> products { get; set; }

        public ProductCategoryModel(string categoryname, string slug)
        {
            CategoryName = categoryname;
            CreationDate = DateTime.Now;
            Slug = slug;

        }
        public void Edit(string categoryName,string slug)
        {
            CategoryName = categoryName;
            Slug = slug;
        }
    }

}
