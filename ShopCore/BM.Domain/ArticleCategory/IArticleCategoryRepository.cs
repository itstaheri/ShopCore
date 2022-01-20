using BM.Application.Contract.ArticleCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Domain.ArticleCategory
{
    public interface IArticleCategoryRepository
    {
        void Create(ArticleCategoryModel commend);
        ArticleCategoryModel GetBy(long Id);
        void Save();
        List<ArticleCategoryViewModel> GetAll();
    }
}
