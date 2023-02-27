
namespace TradeService.infrastructure
{
    public class DbInit
    {
        public static void init(TradeContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
