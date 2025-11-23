using SARPE.Models;

namespace SARPE.Repository
{
    public interface IUsuarioRepository
    {
        Usuario? GetByUsername(string username);
        IEnumerable<Usuario> GetAll();

    }
}
