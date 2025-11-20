using SARPE.Models;

namespace SARPE.Contracts
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetTodosOsClientes();
        Cliente? GetClientePorId(int id);
        void SalvarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void ExcluirClientePorId(int id);
        void ExcluirTodosOsClientes();
    }
}
