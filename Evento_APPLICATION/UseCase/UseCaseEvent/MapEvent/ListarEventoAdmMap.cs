using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using Evento_CORE.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.MapEvent;

public sealed class ListarEventoAdmMap : Profile
{
    public ListarEventoAdmMap()
    {
        CreateMap<ListarEventoAdmRequest, Evento>();
        CreateMap<Evento, ListarEventoAdmResponse>();
    }
}
