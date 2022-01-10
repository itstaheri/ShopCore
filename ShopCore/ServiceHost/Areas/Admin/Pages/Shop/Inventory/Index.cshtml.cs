using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.Application.Contract.ColloeagueDiscount;
using IM.Application.Contract.Inventory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Application.Contracts.Product;

namespace ServiceHost.Areas.Admin.Pages.Shop.Inventory
{
    public class IndexModel : PageModel
    {
        private readonly IInventoryApplication _repository;
        public List<InventoryViewModel> Inventory;
        private readonly IProductApplication _product;
       // public List<SelectListItem> products { get; set; }
       

        public IndexModel(IInventoryApplication repository, IProductApplication product)
        {
            _repository = repository;
            _product = product;
        }

        public void OnGet(SearchInventory x,SearchProduct p)
        {
            Inventory = _repository.GetAll(x);
           

        }
        public void OnPost(SearchInventory x)
        {
            Inventory = _repository.GetAll(x);
        }
        public RedirectToPageResult OnPostIncrease(long Id)
        {
            var commend = new IncreaseInventory
            {
                InventoryId = Id
            };
            _repository.Increase(commend);
            return RedirectToPage("./Index");
        }
        public RedirectToPageResult OnPostReduce(long Id)
        {
            var commend = new ReduceInventory
            {
                InventoryId = Id
            };
            _repository.Reduce(commend);
            return RedirectToPage("./Index");
        }

    }
}