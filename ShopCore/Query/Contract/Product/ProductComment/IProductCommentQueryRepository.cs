using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Product.ProductComment
{
    public interface IProductCommentQueryRepository
    {
        List<ProductCommentQueryModel> Show(long ProductId);
    }
}
