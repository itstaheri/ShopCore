using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Query.Contract.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost.Pages
{
    public class IndexModel : PageModel
    {


        private readonly IProductQueryRepository _repository;
        public List<ProductQueryModel> products;
        public IndexModel(IProductQueryRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            products = _repository.list();
        }
    }
}
