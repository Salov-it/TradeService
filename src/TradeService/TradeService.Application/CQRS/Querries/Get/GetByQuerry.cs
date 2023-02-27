using MediatR;
using TradeService.Domain;

namespace TradeService.Application.CQRS.Querries.Get
{
    public class GetByQuerry  : IRequest<List<Trade>>
    {

    }
}
