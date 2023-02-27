using MediatR;
using Microsoft.AspNetCore.Mvc;
using TradeService.Application.CQRS.Command.Create;
using TradeService.Application.CQRS.Querries.GetByIdQuerry;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TradeService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeController : ControllerBase
    {
        private readonly IMediator mediator;

        public TradeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] int traderId, int buyerId, int value, int price, string status, int requisiteId, int offerId)
        {
            var content = new CreateTradeСommand
            {
                traderId = traderId,
                buyerId = buyerId,
                value = value,
                price = price,
                status = status,
                requisiteId = requisiteId,
                offerId = offerId
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }

        [HttpGet]
        public async Task<IActionResult> GetByOwner(int Id)
        {
            var content = new GetByIdQuerry
            {
                Id = Id
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }
    }

}
