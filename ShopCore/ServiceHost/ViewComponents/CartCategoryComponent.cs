using Microsoft.AspNetCore.Mvc;
using SM.Application.Contracts.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost.ViewComponents
{
    public class CartCategoryViewComponent : ViewComponent
    {
        private readonly IProductCategoryApplication _category;

        public CartCategoryViewComponent(IProductCategoryApplication category)
        {
            _category = category;
        }
        SearchProductCategoryByName isnull;
        public IViewComponentResult Invoke()
        {
            return View(_category.SearchByNames(isnull));
        }
    }
}
