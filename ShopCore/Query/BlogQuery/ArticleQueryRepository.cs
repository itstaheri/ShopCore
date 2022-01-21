using BM.Infrastracture.Efcore;
using Frameworks;
using Microsoft.EntityFrameworkCore;
using Query.Contract.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.BlogQuery
{
    public class ArticleQueryRepository : IArticleQueryRepository
    {
        private readonly BlogContext _context;

        public ArticleQueryRepository(BlogContext context)
        {
            _context = context;
        }

        public ArticleDetailQueryViewModel GetDetail(long Id)
        {
            return _context.articles.Select(x => new ArticleDetailQueryViewModel
            {
                Id =x.Id,
                Description =x.Description,
                CreationDate =x.CreationDate.ToFarsi(),
                ShortDescription =x.ShortDescription,
                CategoryId =x.CategoryId,
                CategoryName =x.articleCategory.Name,
                Picture =x.Picture,
                PictureAlt =x.PictureAlt,
                PictureTitle =x.PictureAlt,
                Title =x.Title,
                Username =x.Username

            }).SingleOrDefault(x=>x.Id == Id);
        }

        public List<ArticleQueryViewModel> List()
        {
            return _context.articles.Where(x=>x.IsRemoved == false).Select(x => new ArticleQueryViewModel
            {
                Id = x.Id,
                CreationDate = x.CreationDate.ToFarsi(),
                ShortDescription = x.ShortDescription,
                CategoryId = x.CategoryId,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Title = x.Title,
                Username = x.Username,
                CategoryName = x.articleCategory.Name

            }).AsNoTracking().ToList();
        }

        public List<ArticleQueryViewModel> Search(string commend)
        {
            return _context.articles.Where(x => x.IsRemoved == false && x.Title.Contains(commend) || x.ShortDescription.Contains(commend))
                .Select(x => new ArticleQueryViewModel
                {
                    Id = x.Id,
                    ShortDescription = x.ShortDescription,
                    CreationDate =x.CreationDate.ToFarsi(),
                    CategoryId =x.CategoryId,
                    CategoryName =x.articleCategory.Name,
                    Picture =x.Picture,
                    PictureAlt =x.PictureAlt,
                    PictureTitle =x.PictureTitle,
                    Title =x.Title,
                    Username = x.Username
                }).ToList();
            
        }
    }
}
