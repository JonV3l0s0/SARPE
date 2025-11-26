using SARPE.Contracts;
using SARPE.Models;
using System.Diagnostics;

namespace SARPE.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly static List<Cliente> _clientes = [];
        private readonly static List<Cliente> _clientesSalvos = [];

        private int GerarProximoId()
        {
            if (_clientesSalvos.Any())
                return _clientesSalvos.Max(p => p.Id) + 1;

            if (_clientes.Any())
                return _clientes.Max(p => p.Id) + 1;

            return 0;
        }

        public void AtualizarCliente(Cliente cliente)
        {
            try
            {
                var clienteAAlterar = GetClientePorId(cliente.Id);
                clienteAAlterar.CnpjCpf = cliente.CnpjCpf;
                clienteAAlterar.RazaoSocial = cliente.RazaoSocial;
                clienteAAlterar.Endereco = cliente.Endereco;
                clienteAAlterar.Cidade = cliente.Cidade;
                clienteAAlterar.Telefone = cliente.Telefone;
                clienteAAlterar.Email = cliente.Email;
                clienteAAlterar.IsAtivo = cliente.IsAtivo;

                Debug.WriteLine("Cliente atualizado com sucesso!");
            }
            catch
            {
                Debug.WriteLine("Erro ao atualizar cliente!");
                throw;
            }
        }

        public void ExcluirClientePorId(int id)
        {
            try
            {
                var cliente = GetClientePorId(id);

                if (cliente is null) return;

                _clientes.Remove(cliente);

                Debug.WriteLine("Cliente excluído com sucesso!");
            }
            catch
            {
                Debug.WriteLine("Erro ao excluir cliente!");
                throw;
            }
        }

        public void ExcluirTodosOsClientes()
        {
            try
            {
                if (!_clientes.Any()) return;

                _clientes.Clear();

                Debug.WriteLine("Todos os clientes foram excluídos!");
            }
            catch
            {
                Debug.WriteLine("Erro ao excluir todos os clientes!");
                throw;
            }
        }

        public Cliente? GetClientePorId(int id)
        {
            return _clientes.FirstOrDefault(c => c.Id == id) == null ? GetClienteSalvoPorId(id) : _clientes.FirstOrDefault(c => c.Id == id);
        }

        public Cliente? GetClienteSalvoPorId(int id)
        {
            return _clientesSalvos.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Cliente> GetTodosOsClientes()
        {
            return _clientes;
        }

        public IEnumerable<Cliente> GetTodosOsClientesSalvos()
        {
            return _clientesSalvos;
        }

        public void SalvarCliente(Cliente cliente)
        {
            try
            {
                cliente.Id = GerarProximoId();
                _clientes.Add(cliente);
                Debug.WriteLine("Cliente salvo com sucesso!");
            }
            catch
            {
                Debug.WriteLine("Erro ao salvar cliente!");
                throw;
            }
        }

        public void SalvarTodosOsClientes()
        {
            try
            {
                _clientesSalvos.AddRange(_clientes);
                _clientes.Clear();
                Debug.WriteLine("Todos os clientes foram salvos com sucesso!");
            }
            catch
            {
                Debug.WriteLine("Erro ao salvar todos os clientes!");
                throw;
            }
        }
    }
}