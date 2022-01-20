using BM.Domain.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Infrastracture.Efcore.Mappings
{
    public class ArticleMapping : IEntityTypeConfiguration<ArticleModel>
    {
        public void Configure(EntityTypeBuilder<ArticleModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.articleCategory).WithMany(x => x.articles).HasForeignKey(x => x.CategoryId);
        }
    }
}
