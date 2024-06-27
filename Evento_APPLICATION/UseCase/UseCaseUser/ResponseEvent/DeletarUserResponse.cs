namespace Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;

public sealed record DeletarUserResponse
{
    public bool Deletado { get; set; }

    public DeletarUserResponse(bool deletado)
    {
        Deletado = deletado;
    }
}
