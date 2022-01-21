using BM.Domain.Article;
using System;
using System.Collections.Generic;

namespace BM.Domain.ArticleCategory
{
    public class ArticleCategoryModel
    {
        protected ArticleCategoryModel() { }
        public ArticleCategoryModel(string name)
        {
            Name = name;
            CreateDate = DateTime.Now;
        }
        public void Edit(string name)
        {
            Name = name;
        }

        public void Remove() => IsRemoved = true;
        public void Active() => IsRemoved = false;
        public long Id { get; private set; }
        public string Name { get; private set; }
        public bool IsRemoved { get; private set; }
        public DateTime CreateDate { get; private set; }
        public List<ArticleModel> articles { get; private set; }
    }
}