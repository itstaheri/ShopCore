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
    public class EditModel : PageModel
    {
        private readonly IProductApplication _repository;
        private readonly IProductCategoryApplication _ProductCategories;
        string pathh;
        [BindProperty] public EditProduct Products { get; set; }
        public List<SelectListItem> Categories { get; set; }

        public List<CatalogeModel> cataloges { get; set; }

        public EditModel(IProductApplication repository, IProductCategoryApplication ProductCategories, [FromServices] IWebHostEnvironment env)
        {
            pathh = Path.Combine(env.WebRootPath,"Img","ProductImages");
            _repository = repository;
            _ProductCategories = ProductCategories;
        }

        public void OnGet(long id, SearchProductCategoryByName commend)
        {

            Products = _repository.GetValueForEdit(id);
            Categories = _ProductCategories.SearchByNames(commend)
                .Select(x => new SelectListItem(x.CategoryName, x.id.ToString())).ToList();

        
            var GetCatelogeImages = Directory.GetFiles(pathh);
            cataloges = new List<CatalogeModel>();
            foreach (var item in GetCatelogeImages)
            {
                
                if (Path.GetFileName(item).Contains(Products.ProductCode))
                {
                    cataloges.Add(new CatalogeModel { Name = Path.GetFileName(item) });
                }
            }
        }
        
        public void OnGetDeletePhoto(string Name)
        {
            System.IO.File.Delete(pathh + Name);
           // return RedirectToPage();
        }

        public RedirectToPageResult OnPost(EditProduct commend, [FromServices] IWebHostEnvironment env)
        {

            #region Upload Photo(S)
            int v = 0;
            if (commend.CatalogeImages !=null)
                foreach (var item in commend.CatalogeImages)
                {
                    v++;
                    var path = Path.Combine(env.WebRootPath, "Img", "ProductImages", commend.ProductCode + v.ToString() + ".jpg");
                    using (var stream = System.IO.File.Create(path))
                    {
                        item.CopyTo(stream);
                    }
                }


            if (commend.OriginalImage !=null)
            {
                var path = Path.Combine(env.WebRootPath, "Img", "ProductImages", commend.ProductCode + ".jpg");
                using (var stream = System.IO.File.Create(path))
                {
                    Products.OriginalImage.CopyTo(stream);
                }
            }




            #endregion
            _repository.Edit(commend);
            return RedirectToPage("./Index");

        }

     

    }
    public class CatalogeModel
    {
        public string Name { get; set; }
    }
}
