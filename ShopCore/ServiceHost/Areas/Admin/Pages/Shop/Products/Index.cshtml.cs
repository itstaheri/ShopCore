using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SM.Application.Contracts.Product;

namespace ServiceHost.Areas.Admin.Pages.Shop.Products
{
    public class IndexModel : PageModel
    {
      private readonly IProductApplication _repository;
      public List<ProductViewModel> Products { get; set; }

        public IndexModel(IProductApplication repository)
        {
            _repository = repository;
        }

        public void OnGet(SearchProduct commend)
        {
            Products = _repository.GetAll(commend);
        }
        public void OnPost(SearchProduct commend)
        {
            Products = _repository.GetAll(commend);
        }
        public RedirectToPageResult OnPostActive(long Id)
        {
            _repository.Active(Id);
            return RedirectToPage("./Index");
        }
        public RedirectToPageResult OnPostDelete(long Id)
        {
            _repository.Remove(Id);
            return RedirectToPage("./Index");
        }
    }
}
