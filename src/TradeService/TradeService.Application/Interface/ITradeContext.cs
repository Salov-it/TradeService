using Microsoft.EntityFrameworkCore;
using TradeService.Domain;

namespace TradeService.Application.Interface
{
    public interface ITradeContext
    {
        public DbSet<Trade> trade { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
