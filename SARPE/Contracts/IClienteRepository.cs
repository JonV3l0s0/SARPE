using SARPE.Models;

namespace SARPE.Contracts
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetTodosOsClientes();
        IEnumerable<Cliente> GetTodosOsClientesSalvos();
        Cliente? GetClientePorId(int id);
        Cliente? GetClienteSalvoPorId(int id);
        void SalvarCliente(Cliente cliente);
        void SalvarTodosOsClientes();
        void AtualizarCliente(Cliente cliente);
        void ExcluirClientePorId(int id);
        void ExcluirTodosOsClientes();
    }
}
