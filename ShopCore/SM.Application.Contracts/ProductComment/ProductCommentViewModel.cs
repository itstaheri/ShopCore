using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.ProductComment
{
    public class ProductCommentViewModel
    {
        public long Id { get;  set; }
        public string Title { get;  set; }
        public string Username { get;  set; }
        public int Status { get;  set; }
        public string CreationDate { get;  set; }
        public string ProductName { get; set; }
        public string Text { get; set; }
    }
}
