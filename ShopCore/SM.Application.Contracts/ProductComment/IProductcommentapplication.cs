using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.ProductComment
{
    public interface IProductcommentapplication
    {
        void Create(CreateProductComment commend);
        List<ProductCommentViewModel> List(ProductCommentSearchModel commend);
        void Confirm(long Id);
        void Cancel(long Id);
    }
}
