using MediatR;
using Microsoft.EntityFrameworkCore;
using TradeService.Application.Interface;
using TradeService.Domain;

namespace TradeService.Application.CQRS.Querries.GetByIdQuerry
{
    public class GetByIdHandler : IRequestHandler<GetByIdQuerry, Trade>
    {
        private readonly ITradeContext _tradeContext;
        public GetByIdHandler(ITradeContext tradeContext)
        {
            _tradeContext = tradeContext;
        }
        public async Task<Trade> Handle(GetByIdQuerry request, CancellationToken cancellationToken)
        {
            return await _tradeContext.trade.FirstOrDefaultAsync(w => w.id == request.Id, cancellationToken);
        }
    }
}
