using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Extensions
{
    public static class ClienteExtensions
    {
        public static ClienteDetalheViewModel ToDetalheViewModel(this Cliente cliente)
        {
            return new()
            {
                Id = cliente.Id,
                CnpjCpf = cliente.CnpjCpf,
                RazaoSocial = cliente.RazaoSocial,
                Endereco = cliente.Endereco,
                Cidade = cliente.Cidade,
                Telefone = cliente.Telefone,
                Email = cliente.Email,
                IsAtivo = cliente.IsAtivo
            };
        }

        public static ClienteEditarDTO ToEditarDTO(this ClienteDetalheViewModel cliente) 
        {
            return new()
            {
                CnpjCpf = cliente.CnpjCpf,
                RazaoSocial = cliente.RazaoSocial,
                Endereco = cliente.Endereco,
                Cidade = cliente.Cidade,
                Telefone = cliente.Telefone,
                Email = cliente.Email,
                IsAtivo = cliente.IsAtivo
            };
        }
    }
}
