using System;
using System.Collections.Generic;
using System.Linq;
using IM.Application.Contract.Inventory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Application.Contracts.Product;

namespace ServiceHost.Areas.Admin.Pages.Shop.Inventory
{
    public class EditModel : PageModel
    {
        private readonly IInventoryApplication _repository;
        public List<SelectListItem> products;
        private readonly IProductApplication _products;


        public EditModel(IInventoryApplication repository, IProductApplication products)
        {
            _repository = repository;
            _products = products;
        }

        [BindProperty] public EditInventory Inventory { get; set; }
        public void OnGet(long Id,SearchProduct x)
        {
            Inventory = _repository.GetValueForEdit(Id);
            products = _products.GetAll(x).Select(x => new SelectListItem(x.ProductName, x.ProductId.ToString(),true,false)).ToList();
        }
        public RedirectToPageResult OnPost(EditInventory commend)
        {
            _repository.Edit(commend);
            return RedirectToPage("./Index");
            
        }
    }
}
