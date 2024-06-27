using Evento_APPLICATION.UseCase.UseCaseUser.RequestEvent;
using FluentValidation;
using FluentValidation.Validators;

namespace Evento_APPLICATION.Validators.ValUser;

public class CriarUsuaroValidator : AbstractValidator<AdicionarUserRequest>
{
    public CriarUsuaroValidator()
    {
        RuleFor(x => x.Email).NotEmpty().MaximumLength(128).EmailAddress();
        RuleFor(x => x.Name).NotEmpty().MaximumLength(64).MinimumLength(3);
        RuleFor(x => x.Senha).NotEmpty().MaximumLength(24).MinimumLength(8);
    }
}
