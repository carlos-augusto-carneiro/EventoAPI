using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using Evento_CORE.Entitys;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.MapEvent;

public sealed class AtualizarEventoMap : Profile
{
    public AtualizarEventoMap()
    {
        CreateMap<AtualizarEventoRequest, Evento>();
        CreateMap<Evento, AtualizarEventoResponse>();
    }
}
