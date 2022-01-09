using Frameworks;
using Query.Contract.Product;
using Query.Contract.Product.ProductComment;
using SM.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.ProductQuery
{
    public class ProductCommentQueryRepository : IProductCommentQueryRepository
    {
        private readonly ShopContext _context;

        public ProductCommentQueryRepository(ShopContext context)
        {
            _context = context;
        }

        public List<ProductCommentQueryModel> Show(long ProductId)
        {
            return _context.productComments.Where(x=>x.Status==1 && x.ProductId == ProductId).Select(x => new ProductCommentQueryModel
            {
                Id = x.Id,
                Text =x.Text,
                CreationDate = x.CreationDate.ToFarsi(),
                Username = "Manager"
            }).ToList();
        }
    }
}
