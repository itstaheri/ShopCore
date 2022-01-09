using SM.Application.Contracts.ProductComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.ProductComment
{
    public interface IProductCommentRepository
    {
        void Create(ProductCommentModel commend);
        List<ProductCommentViewModel> GetAll(ProductCommentSearchModel commend);
        void Save();
        ProductCommentModel GetBy(long Id);

    }
}
