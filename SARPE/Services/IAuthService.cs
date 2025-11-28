using SARPE.Models;

namespace SARPE.Services
{
    public interface IAuthService
    {
        Usuario? ValidateCredentials(string username, string password);
    }
}
