using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Application.Contract.Article
{
    public interface IArticleApplication
    {
        void Create(CreateArticle commend);
        void Edit(EditArticle commend);
        List<ArticleViewModel> List(ArticleSearchModel commend);
        EditArticle GetValueforEdit(long Id);
        void Active(long Id);
        void Remove(long Id);

    }
}
