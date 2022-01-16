using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.Application;
using DM.Application.Contract.ColloeagueDiscount;
using DM.Application.Contract.CustomerDiscount;
using Frameworks;
using IM.Application.Contract.Inventory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Application.Contracts.Product;
using SM.Infrastructure.EfCore.Permisions;

namespace ServiceHost.Areas.Admin.Pages.Shop.Inventory
{
    public class OperationLoggs : PageModel
    {
        private readonly IInventoryApplication _repository;
       [BindProperty] public List<InventoryOperationViewModel> operations { get; set; }

        public OperationLoggs(IInventoryApplication repository)
        {
            _repository = repository;
        }
        [NeedsPermission(InventoryPermission.HistoryInventory)]
        public void OnGet(long Id)
        {
            operations = _repository.GetforLogss(Id);
        }
      
    }
}
