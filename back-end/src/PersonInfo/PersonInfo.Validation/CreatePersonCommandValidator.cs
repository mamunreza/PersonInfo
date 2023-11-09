using FluentValidation;
using PersonInfo.Contract.Commands;

namespace PersonInfo.Validation
{
    public class CreatePersonCommandValidator : AbstractValidator<CreatePersonCommand>
    {
        public CreatePersonCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
            RuleFor(x => x.SectorId)
                .GreaterThan(0);
            RuleFor(x => x.AgreeToTerms)
                .Must(x => x == true);
        }
    }
}