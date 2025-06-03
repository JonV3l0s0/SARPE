namespace SARPE.Models
{
    public class ClienteDetalheViewModel
    {
        public int Id { get; set; }
        public string CnpjCpf { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsAtivo { get; set; } = true;
    }
}
