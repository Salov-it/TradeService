using MediatR;
using TradeService.Domain;

namespace TradeService.Application.CQRS.Command.Create
{
    public class CreateTradeСommand : IRequest<Trade>
    {
        public int id { get; set; }
        public int traderId { get; set; }
        public int buyerId { get; set; }
        public int value { get; set; }
        public decimal price { get; set; }
        public string status { get; set; }
        public int requisiteId { get; set; }
        public string createdAt { get; set; }
        public int offerId { get; set; }
    }
}
