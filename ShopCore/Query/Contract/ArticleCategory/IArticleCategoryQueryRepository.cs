using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.ArticleCategory
{
    public interface IArticleCategoryQueryRepository
    {
        List<ArticleCategoryQueryViewModel> GetProductsWithCategory(long categoryId);
        List<ArticleCategoryQueryViewModel> GetAll();
    }
}
