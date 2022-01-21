using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Article
{
    public interface IArticleQueryRepository
    {
        List<ArticleQueryViewModel> List();
        List<ArticleQueryViewModel> Search(string commend);
        ArticleDetailQueryViewModel GetDetail(long Id);

    }
}
