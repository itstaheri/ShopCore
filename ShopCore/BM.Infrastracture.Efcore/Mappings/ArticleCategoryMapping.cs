using BM.Domain.ArticleCategory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Infrastracture.Efcore.Mappings
{
    public class ArticleCategoryMapping : IEntityTypeConfiguration<ArticleCategoryModel>
    {
        public void Configure(EntityTypeBuilder<ArticleCategoryModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.articles).WithOne(x => x.articleCategory).HasForeignKey(x => x.CategoryId);
        }
    }
}
