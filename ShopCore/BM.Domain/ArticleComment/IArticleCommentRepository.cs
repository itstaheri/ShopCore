using BM.Application.Contract.ArticleComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Domain.ArticleComment
{
    public interface IArticleCommentRepository
    {
        void Create(ArticleCommentModel commend);
        ArticleCommentModel GetBy(long Id);
        void Save();
        List<ArticleCommentViewModel> GetAll(string Username);
    }
}
