using MediatR;
using TradeService.Application.Interface;
using TradeService.Domain;

namespace TradeService.Application.CQRS.Command.UpdateTrade
{
    public class UpdateTradeHandler : IRequestHandler<UpdateTradeCommand, Trade>
    {
        private readonly ITradeContext _context;
        public UpdateTradeHandler(ITradeContext context)
        {
            _context = context;
        }
        public async Task<Trade> Handle(UpdateTradeCommand request, CancellationToken cancellationToken)
        {
            var content = _context.trade.Find(request.id);

            if (content == null)
            {
                // Exception
                return null;
            }

            content.value = request.value;
            content.price = request.price;
            content.status = request.status;
            content.updatedAt = DateTime.UtcNow.ToString();

            await _context.SaveChangesAsync(cancellationToken);
            return content;
        }
    }
}
