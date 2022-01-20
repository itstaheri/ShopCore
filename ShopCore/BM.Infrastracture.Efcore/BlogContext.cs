using BM.Domain.Article;
using BM.Domain.ArticleCategory;
using BM.Domain.ArticleComment;
using BM.Infrastracture.Efcore.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Infrastracture.Efcore
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }
        public DbSet<ArticleModel> articles { get; set; }
        public DbSet<ArticleCategoryModel> articleCategories { get; set; }
        public DbSet<ArticleCommentModel> articleComments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ArticleMapping());
            builder.ApplyConfiguration(new ArticleCategoryMapping());
            base.OnModelCreating(builder);
        }
    }
}
