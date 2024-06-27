using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using Evento_CORE.Entitys;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.MapEvent;

public sealed class ListarEventoMap : Profile
{
    public ListarEventoMap()
    {
        CreateMap<Evento, ListarEventoResponse>();

    }
}
