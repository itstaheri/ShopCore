using System;

namespace SM.Application.Contracts.ProductCategory
{
    public class ProductCategoryViewModel
    {
        public long id  { get; set; }
        public string Picture  { get; set; }
        public string CategoryName { get; set; }
        public bool Isdeleted { get; set; }
        public string CreationDate { get; set; }
        public int ProductCount { get; set; }
        public string Slug { get; set; }
    }
}
