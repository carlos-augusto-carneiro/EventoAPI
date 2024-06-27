using Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;
using FluentValidation;

namespace Evento_APPLICATION.Validators.ValEvent;

public sealed class CriarEventoValidator : AbstractValidator<AdicionarEventoRequest>
{
    public CriarEventoValidator()
    {
        RuleFor(x => x.NameEvent).NotEmpty().MaximumLength(200).MinimumLength(3);
        RuleFor(x => x.Descricao).NotEmpty().MaximumLength(1000).MinimumLength(4);
        RuleFor(x => x.DataDoEventoInicio).NotEmpty()
            .Must(BeAValidDate).WithMessage("Data de início do evento deve ser uma data válida.")
            .Must(BeAFutureDate).WithMessage("Data de início do evento deve ser uma data futura.");

        RuleFor(x => x.DataDoEventoFim).NotEmpty()
            .Must(BeAValidDate).WithMessage("Data de fim do evento deve ser uma data válida.")
            .GreaterThan(x => x.DataDoEventoInicio).WithMessage("Data de fim do evento deve ser posterior à data de início.");
    }

    private bool BeAValidDate(DateTime date)
    {
        return date != default(DateTime);
    }

    private bool BeAFutureDate(DateTime date)
    {
        return date > DateTime.Now;
    }
}
