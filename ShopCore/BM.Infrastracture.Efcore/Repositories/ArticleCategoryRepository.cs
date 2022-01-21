using BM.Application.Contract.ArticleCategory;
using BM.Domain.ArticleCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BM.Infrastracture.Efcore.Repositories
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly BlogContext _context;

        public ArticleCategoryRepository(BlogContext context)
        {
            _context = context;
        }

        public void Create(ArticleCategoryModel commend)
        {
            _context.articleCategories.Add(commend);
            _context.SaveChanges();
        }

        public List<ArticleCategoryViewModel> GetAll()
        {
            return _context.articleCategories.Select(x => new ArticleCategoryViewModel
            {
                Id = x.Id,
                CreateionDate = x.CreateDate.ToString(),
                IsRemoved = x.IsRemoved,
                Name = x.Name,
                ArticleCount = x.articles.Count

            }).ToList();
        }

        public ArticleCategoryModel GetBy(long Id)
        {
            return _context.articleCategories.SingleOrDefault(x => x.Id == Id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
