namespace Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;

public sealed record DeletarAdmResponse
{
    public bool Deletado { get; set; }

    public DeletarAdmResponse(bool deletado)
    {
        Deletado = deletado;
    }
}
