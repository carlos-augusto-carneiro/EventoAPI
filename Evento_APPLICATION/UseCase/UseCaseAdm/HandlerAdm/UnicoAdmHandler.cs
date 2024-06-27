using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;
using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.HandlerAdm
{
    public sealed class UnicoAdmHandler : IRequestHandler<UnicoAdmRequest, UnicoAdmResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAdministrador _administrador;

        public UnicoAdmHandler(IMapper mapper, IAdministrador administrador)
        {
            _mapper = mapper;
            _administrador = administrador;
        }

        public Task<UnicoAdmResponse> Handle(UnicoAdmRequest request, CancellationToken cancellationToken)
        {
            var mapearRequest = _mapper.Map<Administrador>(request);
            _administrador.GetId(request.Id);
            var mapearResponse = _mapper.Map<UnicoAdmResponse>(mapearRequest);

            return Task.FromResult(mapearResponse);
        }
    }
}
