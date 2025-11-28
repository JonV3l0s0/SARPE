using SARPE.Models;

namespace SARPE.Repository
{
    public class InMemoryUsuarioRepository : IUsuarioRepository
    {
        private readonly List<Usuario> _users = new()
        {
        new Usuario { Username = "admin", Senha = "Senha@123", NomeExibido = "Administrador" },
        new Usuario { Username = "jon", Senha = "teste123", NomeExibido = "Jonathan" }
        };

        public Usuario? GetByUsername(string username)
        {
            return _users.FirstOrDefault(u =>
                string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Usuario> GetAll() => _users;
    }
}
