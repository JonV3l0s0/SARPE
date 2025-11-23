using SARPE.Models;
using SARPE.Repository;

namespace SARPE.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public AuthService(IUsuarioRepository usersRepository) => _usuarioRepository = usersRepository;


        public Usuario? ValidateCredentials(string username, string password)
        {
            var user = _usuarioRepository.GetByUsername(username);
            if (user == null) return null;

            // Exemplo simples: comparar senha em texto.
            // Em produção: usar hashing (BCrypt, PBKDF2) e verificação segura.
            return user.Senha == password ? user : null;
        }
    }
}
