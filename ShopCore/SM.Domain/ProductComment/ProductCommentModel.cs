using SM.Domain.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.ProductComment
{
    public class ProductCommentModel
    {
        protected ProductCommentModel()
        {

        }
        public ProductCommentModel(string title, long userId, string text, int productId)
        {
            Title = title;
            UserId = userId;
            Text = text;
            ProductId = productId;
            CreationDate = DateTime.Now;
            Status = CommentStatus.Suspended;
        }
        public void Confirmed() => Status = CommentStatus.Confirm;
        public void Canceled() => Status = CommentStatus.Cancel;

        public long Id { get; private set; }
        public string Title { get; private set; }
        public long UserId { get; private set; }
        public string Text { get; private set; }
        public int ProductId { get; private set; }
        public ProductModel product { get; private set; }
        public int Status { get; private set; }
        public DateTime CreationDate { get; private set; }


    }
}
