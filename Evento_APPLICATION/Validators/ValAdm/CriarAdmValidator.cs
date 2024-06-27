using Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;
using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using FluentValidation;
using FluentValidation.Validators;

namespace Evento_APPLICATION.Validators.ValAdm;

public class CriarAdmValidator : AbstractValidator<AdicionarAdmRequest>
{
    public CriarAdmValidator()
    {
        RuleFor(x => x.Email).NotEmpty().EmailAddress().MaximumLength(128);
        RuleFor(x => x.Name).NotEmpty().MaximumLength(64).MinimumLength(3);
        RuleFor(x => x.Senha).NotEmpty().MaximumLength(24).MinimumLength(8);
    }
}
