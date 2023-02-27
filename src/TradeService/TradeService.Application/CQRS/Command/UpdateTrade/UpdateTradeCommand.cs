using MediatR;
using TradeService.Domain;

namespace TradeService.Application.CQRS.Command.UpdateTrade
{
    public class UpdateTradeCommand : IRequest<Trade>
    {
        public int id { get; set; }
        public int value { get; set; }
        public decimal price { get; set; }
        public string status { get; set; }
        public string updatedAt { get; set; }
    }
}
