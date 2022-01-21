using BM.Application.Contract.Article;
using BM.Domain.Article;
using Frameworks;
using System;
using System.Collections.Generic;

namespace BM.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _repository;
        private readonly IAuthHelper _auth;
        private readonly IFileUploader _Uploader;

        public ArticleApplication(IArticleRepository repository, IAuthHelper auth, IFileUploader Uploader)
        {
            _repository = repository;
            _auth = auth;
            _Uploader = Uploader;
        }

        public void Active(long Id)
        {
            var Article = _repository.GetBy(Id);
            Article.Active();
            _repository.Save();
        }

        public void Create(CreateArticle commend)
        {
            var Picture = _Uploader.Upload(commend.Picture, "ArticleImages", commend.Id.ToString());
            var currentInfo = _auth.CurrentAccountInfo();
            var Article = new ArticleModel(commend.Title, Picture, commend.PictureAlt, commend.Title, commend.ShortDescription, commend.Description,currentInfo.Username , commend.CategoryId);
            _repository.Create(Article);
        }

        public void Edit(EditArticle commend)
        {
            var Picture = _Uploader.Upload(commend.Picture, "ArticleImages", commend.Id.ToString());
            var currentInfo = _auth.CurrentAccountInfo();
            var Article = _repository.GetBy(commend.Id);
            Article.Edit(commend.Title, Picture, commend.PictureAlt, commend.Title, commend.ShortDescription, commend.Description, currentInfo.Username, commend.CategoryId);
            _repository.Save();
        }

        public EditArticle GetValueforEdit(long Id)
        {
            var Article = _repository.GetBy(Id);
            return new EditArticle
            {
                Id = Article.Id,
                Description = Article.Description,             
                ShortDescription = Article.ShortDescription,
                CategoryId = Article.CategoryId,
                PictureTitle = Article.PictureTitle,
                PictureAlt = Article.PictureAlt,
                Title = Article.Title,
               
                
            };
        }

        public List<ArticleViewModel> List(ArticleSearchModel commend)
        {
            return _repository.GetAll(commend);  
        }

        public void Remove(long Id)
        {
            var Article = _repository.GetBy(Id);
            Article.Remove();
            _repository.Save();
        }
    }
}
