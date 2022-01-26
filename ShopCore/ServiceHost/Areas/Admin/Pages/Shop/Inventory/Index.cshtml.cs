using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.Application.Contract.ColloeagueDiscount;
using Frameworks;
using IM.Application.Contract.Inventory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Application.Contracts.Product;
using SM.Infrastructure.EfCore.Permisions;

namespace ServiceHost.Areas.Admin.Pages.Shop.Inventory
{
    public class IndexModel : PageModel
    {
        private readonly IInventoryApplication _repository;
        public List<InventoryViewModel> Inventory;
        private readonly IProductApplication _product;
       

        public IndexModel(IInventoryApplication repository, IProductApplication product)
        {
            _repository = repository;
            _product = product;
        }
        [NeedsPermission(InventoryPermission.ListInventory)]
        public void OnGet(SearchProduct p)
        {
            Inventory = _repository.GetAll(null);

        }
        public void OnPost(SearchInventory x)
        {
            Inventory = _repository.GetAll(x);
        }
        [NeedsPermission(InventoryPermission.IncreaseInventory)]
        public RedirectToPageResult OnPostIncrease(long Id)
        {
            var commend = new IncreaseInventory
            {
                InventoryId = Id
            };
            _repository.Increase(commend);
            return RedirectToPage("./Index");
        }
        [NeedsPermission(InventoryPermission.ReduceInventory)]
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
