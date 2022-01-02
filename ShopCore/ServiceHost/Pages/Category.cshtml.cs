using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Query.Contract.Productcategory;

namespace ServiceHost.Pages
{
    public class CategoryModel : PageModel
    {
        private readonly IProductcategoryQuery _repository;
        public List<ProductCategoryQueyViewModel> categories;
        public CategoryModel(IProductcategoryQuery repository)
        {
            _repository = repository;
        }

        public void OnGet(long CategoryId)
        {
            categories = _repository.GetCategoriesWithProduct(CategoryId);
        }

    }
}
