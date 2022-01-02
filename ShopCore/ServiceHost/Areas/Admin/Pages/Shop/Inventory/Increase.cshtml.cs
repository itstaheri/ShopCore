
using IM.Application.Contract.Inventory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SM.Application.Contracts.Product;

namespace ServiceHost.Areas.Admin.Pages.Shop.Inventory
{
    public class IncreaseModel : PageModel
    {
        private readonly IInventoryApplication _repository;


        public IncreaseModel(IInventoryApplication repository)
        {
            _repository = repository;
        }
        public long InventoryId;
        public void OnGet(long Id)
        {
            InventoryId = Id;
        }
        public RedirectToPageResult OnPost(IncreaseInventory commend)
        {
            _repository.Increase(commend);
            return RedirectToPage("./Index");

        }
    }
}
