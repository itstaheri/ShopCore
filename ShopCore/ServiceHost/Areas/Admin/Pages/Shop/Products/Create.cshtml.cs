using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Application.Contracts.Product;
using SM.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Admin.Pages.Shop.Products
{
    public class CreateModel : PageModel
    {
        public List<SelectListItem> ProductCategories { get; set; }
        private readonly IProductCategoryApplication _productCategory;
        private readonly IProductApplication _repository;
        public CreateModel(IProductApplication repository, IProductCategoryApplication productCategory)
        {
            _repository = repository;
            _productCategory = productCategory;
        }
        public void OnGet(SearchProductCategoryByName commend)
        {

            ProductCategories = _productCategory.SearchByNames(commend).Select(x => new SelectListItem(x.CategoryName, x.id.ToString())).ToList();
        }
        public RedirectToPageResult OnPost(CreateProduct commend, [FromServices] IWebHostEnvironment env)
        {
            int v = 0;

            if (commend.CatalogeImages.Count > 0)
                foreach (var item in commend.CatalogeImages)
                {
                    v++;
                    var path = Path.Combine(env.WebRootPath, "Img", "ProductImages", commend.ProductCode + v.ToString() + ".jpg");
                    using (var stream = System.IO.File.Create(path))
                    {
                        item.CopyTo(stream);
                    }
                }
            if (commend.OriginalImage.Length > 0)
            {
                var path = Path.Combine(env.WebRootPath, "Img", "ProductImages", commend.ProductCode + ".jpg");
                using (var stream = System.IO.File.Create(path))
                {
                    commend.OriginalImage.CopyTo(stream);
                }
            }

            _repository.Create(commend);
            return RedirectToPage("./Index");
        }
    }
}
