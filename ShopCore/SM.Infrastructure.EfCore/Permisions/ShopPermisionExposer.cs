using Frameworks;
using SM.Infrastructure.EfCore.Permisions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastracture.Efcore.Permisions
{
    public class ShopPermisionExposer : IPermisionExposer
    {
        public Dictionary<string, List<PermisionDto>> Expose()
        {
            return new Dictionary<string, List<PermisionDto>>
           {
               {
                   "Product",new List<PermisionDto>
                   {
                       new PermisionDto(ShopPermission.ListProduct,"ListProduct"),
                       new PermisionDto(ShopPermission.SearchProduct,"SearchProducts"),
                       new PermisionDto(ShopPermission.CreateProduct,"CreateProduct"),
                       new PermisionDto(ShopPermission.EditProduct,"EditProduct"),
                   }
               },
                {
                    "ProductCategory",new List<PermisionDto>
                    {
                       new PermisionDto(ShopPermission.ListProductCategory,"ListProductCategory"),
                       new PermisionDto(ShopPermission.SearchProductCategory,"SearchProductsCategory"),
                       new PermisionDto(ShopPermission.CreateProductCategory,"CreateProductCategory"),
                       new PermisionDto(ShopPermission.EditProduct,"EditProductCategory"),
                    }
                },
                 {
                    "ProductComment",new List<PermisionDto>
                    {
                       new PermisionDto(ShopPermission.ActiveOrDeactiveProductComment,"ActiveOrDeactiveProductComment"),
                       new PermisionDto(ShopPermission.ListProductComment,"ListProductComment"),
                    }
                },


           };
        }
    }
}
