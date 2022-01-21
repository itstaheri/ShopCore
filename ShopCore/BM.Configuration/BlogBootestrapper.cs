using BM.Application;
using BM.Application.Contract.Article;
using BM.Application.Contract.ArticleCategory;
using BM.Application.Contract.ArticleComment;
using BM.Domain.Article;
using BM.Domain.ArticleCategory;
using BM.Domain.ArticleComment;
using BM.Infrastracture.Efcore;
using BM.Infrastracture.Efcore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Query.BlogQuery;
using Query.Contract.Article;
using Query.Contract.ArticleCategory;
using Query.Contract.ArticleComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Configuration
{
    public class BlogBootestrapper
    {
        public static void Configuration(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<IArticleApplication, ArticleApplication>();

            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();

            services.AddTransient<IArticleCommentRepository, ArticleCommentRepository>();
            services.AddTransient<IArticleCommentApplication, ArticleCommentApplication>();


           services.AddTransient<IArticleQueryRepository, ArticleQueryRepository>();
          services.AddTransient<IArticleCategoryQueryRepository, ArticlecategoryQueryRepository>();
          services.AddTransient<IArticleCommentsQueryRepository, ArticleCommentsQueryRepository>();

            services.AddDbContext<BlogContext>(x => { x.UseSqlServer(connectionString); });
        }
    }
}
