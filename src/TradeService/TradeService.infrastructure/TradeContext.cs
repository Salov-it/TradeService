using Microsoft.EntityFrameworkCore;
using TradeService.Application.Interface;
using TradeService.Domain;

namespace TradeService.infrastructure
{
    public class TradeContext : DbContext, ITradeContext
    {
        public DbSet<Trade> trade { get; set; }

        public TradeContext(DbContextOptions<TradeContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Config());
            base.OnModelCreating(modelBuilder);
        }
    }
}
