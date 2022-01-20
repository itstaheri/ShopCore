using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Application.Contract.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        void Create(CreateArticleCategory commend);
        void Edit(EditArticleCategory commend);
        EditArticleCategory GetValueForEdit(long Id);
        void remove(long Id);
        void Active(long Id);
        List<ArticleCategoryViewModel> List();
    }
}
