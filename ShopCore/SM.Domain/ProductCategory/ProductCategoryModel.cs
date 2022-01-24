using SM.Domain.Product;
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
        public string Picture { get; private set; }
        public DateTime CreationDate { get; private set; }
        public string Slug { get; private set; }
        public bool IsDeleted { get; private set; }
        public List<ProductModel> products { get; set; }


        protected ProductCategoryModel()
        {

        }
        public ProductCategoryModel(string categoryname, string slug, string picture)
        {
            CategoryName = categoryname;
            CreationDate = DateTime.Now;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;

            Slug = slug;
            IsDeleted = false;

        }
        public void Edit(string categoryName, string slug, string picture)
        {
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            CategoryName = categoryName;
            Slug = slug;
        }

        public void Deleted() => IsDeleted = true;
        public void Active() => IsDeleted = false;
    }

}
