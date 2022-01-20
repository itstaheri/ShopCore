using BM.Domain.Article;
using System;

namespace BM.Domain.ArticleComment
{
    public class ArticleCommentModel
    {
        protected ArticleCommentModel() { }
        public ArticleCommentModel(string title, string text, string username, long articleId)
        {
            Title = title;
            Text = text;
            Username = username;
            ArticleId = articleId;
            CreateDate = DateTime.Now;
            IsActive = false;
        }
        public void Active() => IsActive = true;
        public void DeActive() => IsActive = false;

        public long Id { get;private set; }
        public string Title { get; private set; }
        public string Text { get; private set; }
        public string Username { get; private set; }
        public long ArticleId { get; private set; }
        public bool IsActive { get; private set; }
        public ArticleModel article { get; private set; }
        public DateTime CreateDate { get; private set; }
    }
}