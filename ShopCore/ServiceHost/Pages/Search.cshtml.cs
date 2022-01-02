using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Query.Contract.Product;
using SM.Domain.Product;

namespace ServiceHost.Pages
{
    public class SearchModel : PageModel
    {
        public string Value;
        public List<ProductQueryModel> products;
        private readonly IProductQueryRepository _repository;

        public SearchModel(IProductQueryRepository repository)
        {
            _repository = repository;
        }

        public void OnGet(string commend)
        {
            Value = commend;
            products = _repository.Search(commend);
        }
    }
}
