using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SM.Application.Contracts.Order;

namespace ServiceHost.Areas.Admin.Pages.Shop.Orders
{
    public class OrderDetailValueModel : PageModel
    {
        private readonly IOrderApplication _repository;
        public List<OrderDetailViewModel> OrderDetail { get; set; }

        public OrderDetailValueModel(IOrderApplication repository)
        {
            _repository = repository;
        }
        public void OnGet(long Id)
        {
            OrderDetail = _repository.GetOrderdetail(Id);
        }
    }
}
