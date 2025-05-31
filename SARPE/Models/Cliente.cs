namespace SARPE.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string CnpjCpf { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsAtivo { get; set; } = true;


        #region Construtor
        public Cliente(string cnpjCpf, string razaoSocial, string endereco, string cidade, string telefone, string email, bool isAtivo)
        {
            CnpjCpf = cnpjCpf;
            RazaoSocial = razaoSocial;
            Endereco = endereco;
            Cidade = cidade;
            Telefone = telefone;
            Email = email;
            IsAtivo = isAtivo;
        }

        // Construtor sem argumentos para compatibilidade com Entity Framework
        public Cliente()
        {
        }

        // Construtor para testes

        public Cliente(int id, string cnpjCpf, string razaoSocial, string endereco, string cidade, string telefone, string email, bool isAtivo)
        {
            Id = id;
            CnpjCpf = cnpjCpf;
            RazaoSocial = razaoSocial;
            Endereco = endereco;
            Cidade = cidade;
            Telefone = telefone;
            Email = email;
            IsAtivo = isAtivo;
        }
        #endregion Construtor


        #region HashCode e Equals
        public override bool Equals(object? obj)
        {
            return Equals(obj as Cliente);
        }

        public bool Equals(Cliente? other)
        {
            return other is not null &&
                Id == other.Id &&
                CnpjCpf == other.CnpjCpf &&
                RazaoSocial == other.RazaoSocial;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CnpjCpf, RazaoSocial);
        }

        #endregion HashCode e Equals

    }
}
