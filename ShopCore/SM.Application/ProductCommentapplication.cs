using SM.Application.Contracts.ProductComment;
using SM.Domain.ProductComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application
{
    public class ProductCommentapplication : IProductcommentapplication
    {
        private readonly IProductCommentRepository _repository;

        public ProductCommentapplication(IProductCommentRepository repository)
        {
            _repository = repository;
        }

        public void Cancel(long Id)
        {
            var comment = _repository.GetBy(Id);
            comment.Canceled();
            _repository.Save();
        }

        public void Confirm(long Id)
        {
            var comment = _repository.GetBy(Id);
            comment.Confirmed();
            _repository.Save();
        }

        public void Create(CreateProductComment commend)
        {
            var Comment = new ProductCommentModel(commend.Title, commend.UserId, commend.Text, commend.ProductId);
            _repository.Create(Comment);
        }

        public List<ProductCommentViewModel> List(ProductCommentSearchModel commend)
        {
            return _repository.GetAll(commend);
        }
    }
}
