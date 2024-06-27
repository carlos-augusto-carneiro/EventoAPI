using Evento_CORE.Entitys;

namespace Evento_CORE.Repositorys;

public interface IConfirmarUsuario
{
    Task<ConfirmarUsuario> AddAsync(ConfirmarUsuario confirmarUsuario);
    Task<ConfirmarUsuario> ConfirmarPresen(Guid idUsuario, Guid idEvento);
    Task<bool> CancelarPresen(Guid id);
    Task<ConfirmarUsuario> AtualizarPresnc(Guid id, ConfirmarUsuario confirmar);
    Task<ConfirmarUsuario?> GetId(Guid id);
    Task<List<ConfirmarUsuario>> GetListUser(Guid idUser);
    Task<List<ConfirmarUsuario>> GetListEvento(Guid idEvento);
}
