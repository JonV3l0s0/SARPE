using SARPE.Contracts;
using SARPE.Models;
using System.Diagnostics;

namespace SARPE.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly static List<Cliente> _clientes =
            [
            new(1,"12345678914","Nome S.A.","Rua um","Taubaté","1236871542","nome@gmail.com",true),
            new(2,"12345678915","Nome S.A. 1","Rua dois","Taubaté","1236871543","nome1@gmail.com",true),
            new(3,"12345678916","Nome S.A. 2","Rua tres","Taubaté","1236871544","nome2@gmail.com",false),
            ];

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

        public Cliente? GetClientePorId(int id)
        {
            return _clientes.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Cliente> GetTodosOsClientes()
        {
            return _clientes;
        }

        public void SalvarCliente(Cliente cliente)
        {
            try
            {
                _clientes.Add(cliente);
                Debug.WriteLine("Cliente salvo com sucesso!");
            }
            catch
            {
                Debug.WriteLine("Erro ao salvar cliente!");
                throw;
            }
        }
    }
}
