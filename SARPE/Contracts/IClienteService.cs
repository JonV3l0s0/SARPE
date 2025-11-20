using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Contracts
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetTodosOsClientes();
        Cliente? GetClientePorId(int id);
        void SalvarCliente(ClienteCriarDTO clienteDTO);
        void AtualizarCliente(int id, ClienteEditarDTO clienteDTO);
        void ExcluirClientePorId(int id);
        void ExcluirTodosOsClientes();
    }
}
