using SARPE.Enums;

namespace SARPE.DTO
{
    public class ClienteCriarDTO
    {
        public ETipoEntidade? TipoEntidade { get; set; } = ETipoEntidade.Cliente;
        public string CnpjCpf { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsAtivo { get; set; } = true;
    }
}
