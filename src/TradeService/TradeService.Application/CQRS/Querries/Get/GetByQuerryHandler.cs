using MediatR;
using Microsoft.EntityFrameworkCore;
using TradeService.Application.Interface;
using TradeService.Domain;

namespace TradeService.Application.CQRS.Querries.Get
{
    public class GetByQuerryHandler : IRequestHandler<GetByQuerry, List<Trade>>
    {
        private readonly ITradeContext _context;
        public GetByQuerryHandler(ITradeContext context)
        {
            _context = context;
        }

        public async Task<List<Trade>> Handle(GetByQuerry request, CancellationToken cancellationToken)
        {
            return await _context.trade.ToListAsync(cancellationToken);
        }
    }
}
