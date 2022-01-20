using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Application.Contract.ArticleComment
{
    public interface IArticleCommentApplication
    {
        void Create(CreateArticleComment commend);
        void remove(long Id);
        void Active(long Id);
        List<ArticleCommentViewModel> List(string Username);
    }
}
