using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Application.Contract.ArticleComment
{
    public class EditArticleComment : CreateArticleComment
    {
        public long Id { get; set; }
    }
}
