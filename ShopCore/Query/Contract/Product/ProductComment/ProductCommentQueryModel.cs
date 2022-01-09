using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Product.ProductComment
{
    public class ProductCommentQueryModel
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string CreationDate { get; set; }
        public string Username { get; set; }
    }
}
