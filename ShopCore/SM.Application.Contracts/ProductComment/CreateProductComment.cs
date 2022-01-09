using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.ProductComment
{
    public class CreateProductComment
    {
        public string Title { get; set; }
        public long UserId { get; set; }
        public string Text { get; set; }
        public int ProductId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
