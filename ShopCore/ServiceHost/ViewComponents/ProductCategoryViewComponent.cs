using Microsoft.AspNetCore.Mvc;
using Query.Contract.Productcategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost.ViewComponents
{
    public class ProductCategoryViewComponent : ViewComponent
    {
        private readonly IProductcategoryQuery _Query;

        public ProductCategoryViewComponent(IProductcategoryQuery query)
        {
            _Query = query;
        }

        public IViewComponentResult Invoke()
        {
            return View(_Query.GetAll());
        }
    }
}
