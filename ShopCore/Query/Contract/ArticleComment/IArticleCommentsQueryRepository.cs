using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.ArticleComment
{
    public interface IArticleCommentsQueryRepository
    {
        List<ArticleCommentQueryViewModel> Show(long Id);
        List<ArticleCommentQueryViewModel> GetAll();
    }
}
