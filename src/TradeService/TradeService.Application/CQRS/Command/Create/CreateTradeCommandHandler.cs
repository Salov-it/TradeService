using MediatR;
using System.Diagnostics;
using TradeService.Application.Interface;
using TradeService.Domain;
using TradeService.infrastructure;

namespace TradeService.Application.CQRS.Command.Create
{
    public class CreateTradeCommandHandler : IRequestHandler<CreateTradeСommand, Trade>
    {
        public CreateTradeCommandHandler(ITradeContext context)
        {
            _tradeContext = context;
        }
        private readonly ITradeContext _tradeContext;
        public async Task<Trade> Handle(CreateTradeСommand request, CancellationToken cancellationToken)
        {
            var content = new Trade
            {
                traderId = request.traderId,
                buyerId = request.buyerId,
                value = request.value,
                price = request.price,
                requisiteId = request.requisiteId,
                status = request.status,
                offerId = request.offerId,
                createdAt = DateTime.UtcNow.ToString(),
            };
            
            await _tradeContext.trade.AddRangeAsync(content);
            await _tradeContext.SaveChangesAsync(cancellationToken);

            return content;
        }
    }
}
