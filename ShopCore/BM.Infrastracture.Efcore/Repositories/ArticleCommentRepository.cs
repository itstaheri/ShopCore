using AM.Infrastracture.Efcore;
using BM.Application.Contract.ArticleComment;
using BM.Domain.ArticleComment;
using Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Infrastracture.Efcore.Repositories
{
    public class ArticleCommentRepository : IArticleCommentRepository
    {
        private readonly BlogContext _context;
        private readonly AccountContext _account;

        public ArticleCommentRepository(BlogContext context, AccountContext account)
        {
            _context = context;
            _account = account;
        }

        public void Create(ArticleCommentModel commend)
        {
            _context.articleComments.Add(commend);
            _context.SaveChanges();
        }

        public List<ArticleCommentViewModel> GetAll(string Username)
        {
         
            var query = _context.articleComments.Select(x => new ArticleCommentViewModel
            {
                Id = x.Id,
                CreateDate = x.CreateDate.ToFarsi(),
                Text = x.Text,
                title =x.Title,
                Username = x.Username,
                ArticleId = x.ArticleId

            }).ToList();
            foreach (var item in query)
            {
                var article = _context.articles.SingleOrDefault(x => x.Id == item.ArticleId).Title;

                item.ArticleName = article;
            }
          
            if (!string.IsNullOrWhiteSpace(Username))
                query = query.Where(x => x.Username == Username).ToList();

            return query;
            
        }

        public ArticleCommentModel GetBy(long Id)
        {
            return _context.articleComments.SingleOrDefault(x => x.Id == Id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
