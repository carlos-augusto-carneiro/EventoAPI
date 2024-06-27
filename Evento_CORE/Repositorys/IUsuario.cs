using Evento_CORE.Entitys;

namespace Evento_CORE.Repositorys;

public interface IUsuario
{
    Task<Usuario> CreatedUser(Usuario usuario);
    Task<bool> DeletedUser(Guid id);
    Task<Usuario> AtualizarUser(Guid id, Usuario usuario);
    Task<List<Usuario>> ListUser();
    Task<Usuario> GetId(Guid id);
    Task<List<Evento>> GetListEventoUser(Guid idUser);
}
