using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Contracts
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetTodosOsClientes();
        IEnumerable<Cliente> GetTodosOsClientesSalvos();
        Cliente? GetClientePorId(int id);
        Cliente? GetClienteSalvoPorId(int id);
        void SalvarCliente(ClienteCriarDTO clienteDTO);
        void SalvarTodosOsClientes();
        void AtualizarCliente(int id, ClienteEditarDTO clienteDTO);
        void ExcluirClientePorId(int id);
        void ExcluirTodosOsClientes();
    }
}
