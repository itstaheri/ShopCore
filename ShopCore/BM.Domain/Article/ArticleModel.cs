using BM.Domain.ArticleCategory;
using BM.Domain.ArticleComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Domain.Article
{
    public class ArticleModel
    {
        protected ArticleModel() { }
        public ArticleModel(string title, string picture, string pictureAlt, string pictureTitle, string shortDescription, string description, string username, long categoryId)
        {
           

            Title = title;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ShortDescription = shortDescription;
            Description = description;
            Username = username;
            CategoryId = categoryId;
            IsRemoved = false;
            CreationDate = DateTime.Now;
        }
        public void Edit(string title, string picture, string pictureAlt, string pictureTitle, string shortDescription, string description, string username, long categoryId)
        {
            Title = title;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ShortDescription = shortDescription;
            Description = description;
            Username = username;
            CategoryId = categoryId;
           
        }
        public void Remove() => IsRemoved = true;
        public void Active() => IsRemoved = false;

     

        public long Id { get; private set; }
        public string Title { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public bool IsRemoved { get; private set; }
        public DateTime CreationDate { get; private set; }
       public string Username { get;private set; }
        public List<ArticleCommentModel> articleComments { get; private set; }
        public long CategoryId { get; private set; }
        public ArticleCategoryModel articleCategory { get; private set; }


    }
}
