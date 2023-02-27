using FluentValidation;

namespace TradeService.Application.CQRS.Command.UpdateTrade
{
    public class UpdateCommandValidator : AbstractValidator<UpdateTradeCommand>
    {
        public UpdateCommandValidator()
        {
            RuleFor(opt => opt.id).NotEmpty();
            RuleFor(opt => opt.id).GreaterThan(0);
            RuleFor(opr => opr.value).GreaterThan(0);
            RuleFor(opr => opr.price).GreaterThan(0);
        }
    }
}
