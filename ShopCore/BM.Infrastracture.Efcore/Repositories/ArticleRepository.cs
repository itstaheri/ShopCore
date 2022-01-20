using BM.Application.Contract.Article;
using BM.Domain.Article;
using Frameworks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Infrastracture.Efcore.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly BlogContext _context;

        public ArticleRepository(BlogContext context)
        {
            _context = context;
        }

        public void Create(ArticleModel commend)
        {
            _context.articles.Add(commend);
            _context.SaveChanges();
        }

        public List<ArticleViewModel> GetAll(ArticleSearchModel commend)
        {
            var query = _context.articles.Include(x=>x.articleCategory).Select(x => new ArticleViewModel
            {
                Id = x.Id,
                Description = x.Description,
                CreationDate = x.CreationDate.ToFarsi(),
                ShortDescription = x.ShortDescription,
                CategoryId = x.articleCategory.Id,
                IsRemoved = x.IsRemoved,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Title = x.Title,
                Username = x.Username



            });

            foreach (var item in query)
            {
                var category = _context.articleCategories.SingleOrDefault(x => x.Id == item.CategoryId).Name;
                item.CategoryName = item.CategoryName;
            }
            if (commend!=null)
            {
                if (!string.IsNullOrWhiteSpace(commend.Title))
                    query = query.Where(x => x.Title == commend.Title);
            }
            return query.ToList();
        }

        public ArticleModel GetBy(long Id)
        {
            return _context.articles.SingleOrDefault(x => x.Id == Id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
