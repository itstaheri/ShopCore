using BM.Application.Contract.ArticleCategory;
using BM.Domain.ArticleCategory;
using System;
using System.Collections.Generic;

namespace BM.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
       private readonly IArticleCategoryRepository _repository;

        public ArticleCategoryApplication(IArticleCategoryRepository repository)
        {
            _repository = repository;
        }

        public void Active(long Id)
        {
            var ArticleCategory =_repository.GetBy(Id);
            ArticleCategory.Active();
            _repository.Save();

        }

        public void Create(CreateArticleCategory commend)
        {
            var ArticleCategory = new ArticleCategoryModel(commend.Name);
            _repository.Create(ArticleCategory);

        }

        public void Edit(EditArticleCategory commend)
        {
            var ArticleCategory = _repository.GetBy(commend.Id);
            ArticleCategory.Edit(commend.Name);
            _repository.Save();
        }

        public EditArticleCategory GetValueForEdit(long Id)
        {
            var ArticleCategory = _repository.GetBy(Id);
            return new EditArticleCategory
            {
                Id = ArticleCategory.Id,
                Name = ArticleCategory.Name
            };
        }

        public List<ArticleCategoryViewModel> List()
        {
            return _repository.GetAll();
        }

        public void remove(long Id)
        {
            var ArticleCategory = _repository.GetBy(Id);
            ArticleCategory.Remove();
            _repository.Save();
        }
    }
}
