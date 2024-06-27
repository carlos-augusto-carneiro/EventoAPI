namespace Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;

public sealed record UnicoEventoResponse
{
    public string NameEvent { get; private set; }
    public string Descricao { get; private set; }
    public DateTime DataDoEventoInicio { get; private set; }
    public DateTime DataDoEventoFim { get; private set; }
    public int MaxConvidados { get; private set; }
    public float Preco { get; private set; }

    public UnicoEventoResponse(string nameEvent, string descricao)
    {
        NameEvent = nameEvent;
        Descricao = descricao;
    }
}
