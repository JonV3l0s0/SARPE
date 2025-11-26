using SARPE.Models;

namespace SARPE.Repository
{
    public class InMemoryUsuarioRepository : IUsuarioRepository
    {
        private readonly List<Usuario> _users = new()
        {
            new Usuario { Username = "admin", Senha = "admin123", NomeExibido = "Administrador" },
        };

        public Usuario? GetByUsername(string username)
        {
            return _users.FirstOrDefault(u =>
                string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Usuario> GetAll() => _users;
    }
}
