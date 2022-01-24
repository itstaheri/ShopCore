using AM.Infrastracture.Efcore;
using BM.Infrastracture.Efcore;
using Frameworks;
using Query.Contract.ArticleComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.BlogQuery
{
    public class ArticleCommentsQueryRepository : IArticleCommentsQueryRepository
    {
        private readonly BlogContext _context;
        private readonly AccountContext _account;

        public ArticleCommentsQueryRepository(BlogContext context, AccountContext account)
        {
            _context = context;
            _account = account;
        }

        public List<ArticleCommentQueryViewModel> GetAll()
        {
            return _context.articleComments.Where(x => x.IsActive == true).Select(x => new ArticleCommentQueryViewModel
            {
                Id = x.Id,
                CreationDate = x.CreateDate.ToFarsi(),
                ArticleId = x.ArticleId,
                text = x.Text,
                title = x.Title,
                Username = x.Username
            }).ToList();
        }

        public List<ArticleCommentQueryViewModel> Show(long Id)
        {
            var  query = _context.articleComments.Where(x => x.IsActive == true && x.ArticleId == Id).Select(x => new ArticleCommentQueryViewModel
            {
                Id =x.Id,
                CreationDate =x.CreateDate.ToFarsi(),
                ArticleId = x.ArticleId,
                text =x.Title,
                title =x.Title,
                Username =x.Username,
              
            }).ToList();

            foreach (var item in query)
            {
                var picture = _account.accounts.FirstOrDefault(x => x.Username == item.Username).ProfilePicture;
                item.Picture = picture;
            }
            return query;
        }
    }
}
