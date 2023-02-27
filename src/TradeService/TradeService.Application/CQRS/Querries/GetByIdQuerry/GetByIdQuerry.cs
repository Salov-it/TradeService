using MediatR;
using TradeService.Domain;

namespace TradeService.Application.CQRS.Querries.GetByIdQuerry
{
    public class GetByIdQuerry : IRequest<Trade>
    {
        public int Id { get; set; }
    }
}
