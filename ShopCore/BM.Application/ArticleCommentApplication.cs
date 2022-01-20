using BM.Application.Contract.ArticleComment;
using BM.Domain.Article;
using BM.Domain.ArticleComment;
using Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Application
{
    public class ArticleCommentApplication : IArticleCommentApplication
    {
        private readonly IArticleCommentRepository _repository;
        private readonly IAuthHelper _auth;
        public ArticleCommentApplication(IArticleCommentRepository repository, IAuthHelper auth)
        {
            _repository = repository;
            _auth = auth;
        }

        public void Active(long Id)
        {
            var AC = _repository.GetBy(Id);
            AC.Active();
            _repository.Save();
        }

        public void Create(CreateArticleComment commend)
        {
            var currentInfo = _auth.CurrentAccountInfo();
            var Ac = new ArticleCommentModel(commend.title, commend.Text, currentInfo.Username, commend.ArticleId);
            _repository.Create(Ac);

        }


        public List<ArticleCommentViewModel> List(string Username)
        {
            return _repository.GetAll(Username);
        }

        public void remove(long Id)
        {
            var AC = _repository.GetBy(Id);
            AC.DeActive();
            _repository.Save();
        }
    }
}
