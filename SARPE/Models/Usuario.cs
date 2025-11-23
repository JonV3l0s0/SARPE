namespace SARPE.Models
{
    public class Usuario
    {
        public string Username { get; set; } = default!;
        public string Senha { get; set; } = default!; // só para demo; em prod usar hash
        public string NomeExibido { get; set; } = default!;

    }
}
