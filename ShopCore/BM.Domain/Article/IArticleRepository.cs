using BM.Application.Contract.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Domain.Article
{
    public interface IArticleRepository
    {
        void Create(ArticleModel commend);
        ArticleModel GetBy(long Id);
        void Save();
        List<ArticleViewModel> GetAll(ArticleSearchModel commend);
        
    }
}
