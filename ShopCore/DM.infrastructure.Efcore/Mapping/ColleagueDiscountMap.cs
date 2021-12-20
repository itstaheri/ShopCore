using DM.Domain.ColleagueDiscount;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DM.infrastructure.Efcore.Mapping
{
    public class ColleagueDiscountMap : IEntityTypeConfiguration<ColleagueDiscountModel>
    {
        public void Configure(EntityTypeBuilder<ColleagueDiscountModel> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
