using Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento_APPLICATION.Validators.ValAdm;

public  class AtualizarAdmValidator : AbstractValidator<AtualizarAdmRequest>
{
    public AtualizarAdmValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(64).MinimumLength(3);
        RuleFor(x => x.Senha).NotEmpty().MaximumLength(24).MinimumLength(8);
    }
}
