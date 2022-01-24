using BM.Domain.Article;
using BM.Infrastracture.Efcore;
using Frameworks;
using Microsoft.EntityFrameworkCore;
using Query.Contract.Article;
using Query.Contract.ArticleCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.BlogQuery
{
    public class ArticlecategoryQueryRepository : IArticleCategoryQueryRepository
    {
        private readonly BlogContext _context;

        public ArticlecategoryQueryRepository(BlogContext context)
        {
            _context = context;
        }

        public List<ArticleCategoryQueryViewModel> GetProductsWithCategory(long categoryId)
        {
            return _context.articleCategories.Where(x=>x.IsRemoved == false && x.Id == categoryId).Include(x => x.articles).ThenInclude(x => x.articleCategory).Select(x => new ArticleCategoryQueryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                articles = Mapping(x.articles)
            }).AsNoTracking().ToList();

           
        }

        private static List<ArticleQueryViewModel> Mapping(List<ArticleModel> articles)
        {
            return articles.Where(x => x.IsRemoved == false).Select(x => new ArticleQueryViewModel
            {
                Id =x.Id,
                CreationDate =x.CreationDate.ToFarsi(),
                ShortDescription =x.ShortDescription,
                CategoryId = x.CategoryId,
                CategoryName = x.articleCategory.Name,
                Picture =x.Picture,
                PictureAlt =x.PictureAlt,
                PictureTitle =x.PictureTitle,
                Title =x.Title,
                Username = x.Username
            }).ToList();
        }

        public List<ArticleCategoryQueryViewModel> GetAll()
        {
            var query = _context.articleCategories.Select(x => new ArticleCategoryQueryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                
             
            }).AsNoTracking().ToList();

            return query;
        }
    }
}
