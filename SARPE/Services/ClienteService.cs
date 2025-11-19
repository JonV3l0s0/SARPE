using SARPE.Contracts;
using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void AtualizarCliente(int id, ClienteEditarDTO clienteDTO)
        {
            var cliente = GetClientePorId(id);
            if (cliente == null)
                return;
            cliente.CnpjCpf = clienteDTO.CnpjCpf;
            cliente.RazaoSocial = clienteDTO.RazaoSocial;
            cliente.Endereco = clienteDTO.Endereco;
            cliente.Cidade = clienteDTO.Cidade;
            cliente.Telefone = clienteDTO.Telefone;
            cliente.Email = clienteDTO.Email;
            cliente.IsAtivo = clienteDTO.IsAtivo;

            _clienteRepository.AtualizarCliente(cliente);
        }

        public void ExcluirClientePorId(int id)
        {
            _clienteRepository.ExcluirClientePorId(id);
        }

        public Cliente? GetClientePorId(int id)
        {
            var cliente = _clienteRepository.GetClientePorId(id);
            return cliente;
        }

        public IEnumerable<Cliente> GetTodosOsClientes()
        {
            var todosOsClientes = _clienteRepository.GetTodosOsClientes();
            return todosOsClientes;
        }

        public void SalvarCliente(ClienteCriarDTO clienteDTO)
        {
            var id = GetTodosOsClientes().Count() == 0 ? 0 : GetTodosOsClientes().Last().Id + 5;

            var cliente = new Cliente
                (
                id,
                clienteDTO.CnpjCpf,
                clienteDTO.RazaoSocial,
                clienteDTO.Endereco,
                clienteDTO.Cidade,
                clienteDTO.Telefone,
                clienteDTO.Email,
                clienteDTO.IsAtivo
                );

            _clienteRepository.SalvarCliente(cliente);
        }
    }
}
