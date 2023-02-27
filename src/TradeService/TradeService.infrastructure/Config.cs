using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TradeService.Domain;

namespace TradeService.infrastructure
{
    internal class Config : IEntityTypeConfiguration<Trade>
    {
        public void Configure(EntityTypeBuilder<Trade> builder)
        {
            builder.HasIndex(w => w.id).IsUnique();
            builder.HasKey(w => w.id);

        }
    }
}
