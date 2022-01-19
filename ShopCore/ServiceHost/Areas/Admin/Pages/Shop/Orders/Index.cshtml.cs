using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SM.Application.Contracts.Order;

namespace ServiceHost.Areas.Admin.Pages.Shop.Orders
{
    public class IndexModel : PageModel
    {
        private readonly IOrderApplication _repository;
        public List<OrderViewmodel> Orders { get; set; }
        public IndexModel(IOrderApplication repository)
        {
            _repository = repository;
        }
        OrderSearchModel Isnull;
        public void OnGet()
        {
            Orders = _repository.GetOrders(Isnull);
        }
        public void OnPost(OrderSearchModel commend)
        {
            Orders = _repository.GetOrders(commend);

        }
        public RedirectToPageResult OnPostStatusSended(long OrderId)
        {
            _repository.ChangeStatusToSended(OrderId);
            return RedirectToPage("./index");
        }
        public RedirectToPageResult OnPostStatusPending(long OrderId)
        {
            _repository.ChangeStatusToPending(OrderId);
            return RedirectToPage("./index");
        }
        public RedirectToPageResult OnPostStatusCanceled(long OrderId)
        {
            _repository.ChangeStatusToCanceled(OrderId);
            return RedirectToPage("./index");
        }
    }
}
