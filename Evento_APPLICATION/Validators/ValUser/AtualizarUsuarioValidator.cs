using Evento_APPLICATION.UseCase.UseCaseUser.RequestEvent;
using FluentValidation;

namespace Evento_APPLICATION.Validators.ValUser;

public sealed class AtualizarUsuarioValidator : AbstractValidator<AtualizarUserRequest>
{
    public AtualizarUsuarioValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(64).MinimumLength(3);
        RuleFor(x => x.Senha).NotEmpty().MaximumLength(24).MinimumLength(8);
    }
}
