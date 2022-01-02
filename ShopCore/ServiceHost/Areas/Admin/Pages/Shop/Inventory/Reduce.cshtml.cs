
using IM.Application.Contract.Inventory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SM.Application.Contracts.Product;

namespace ServiceHost.Areas.Admin.Pages.Shop.Inventory
{
    public class ReduceModel : PageModel
    {
        private readonly IInventoryApplication _repository;


        public ReduceModel(IInventoryApplication repository)
        {
            _repository = repository;
        }
        public long InventoryId;
        public void OnGet(long Id)
        {
            InventoryId = Id;
        }
        public RedirectToPageResult OnPost(ReduceInventory commend)
        {
            _repository.Reduce(commend);
            return RedirectToPage("./Index");

        }
    }
}
