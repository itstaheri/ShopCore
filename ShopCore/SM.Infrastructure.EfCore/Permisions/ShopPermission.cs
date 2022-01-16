using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.EfCore.Permisions
{
    public static class ShopPermission
    {
        //product
        public const int ListProduct = 10;
        public const int SearchProduct = 11;
        public const int CreateProduct = 12;
        public const int EditProduct = 13;

        //ProductComment
        public const int ListProductComment = 5;
        public const int ActiveOrDeactiveProductComment = 6;
   

        //productcategory
        public const int ListProductCategory = 21;
        public const int SearchProductCategory = 22;
        public const int CreateProductCategory = 23;
        public const int EditProductCategory = 24;
    }
}
