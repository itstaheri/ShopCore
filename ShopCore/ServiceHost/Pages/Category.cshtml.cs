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
        public string Result;
        public CategoryModel(IProductcategoryQuery repository)
        {
            _repository = repository;
        }

        public void OnGet(long CategoryId)
        {
            Result = _repository.GetCategoriesWithProduct(CategoryId).FirstOrDefault(x => x.Id == CategoryId).CategoryName;
            categories = _repository.GetCategoriesWithProduct(CategoryId);
        }

    }
}
