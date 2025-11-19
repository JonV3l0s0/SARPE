using SARPE.Enums;

namespace SARPE.Models
{
    public class Estoque : IEquatable<Estoque?>
    {
        public int Id { get;  set; }
        public string Nome { get; set; } = string.Empty;
        public long Quantidade { get; set; } = 0;
        public EStatusEstoque Status { get; set; } = EStatusEstoque.Indisponivel;

        // Provavelmente precisa-se de construtor sem argumentos por conta do EntityFramework
        // obs: Averiguar essa informação
        #region Construtor
        public Estoque()
        {
        }

        public Estoque(int id,string nome, long quantidade, EStatusEstoque status)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Status = status;
        }
        #endregion Construtor

        #region HashCode e Equals
        public override bool Equals(object? obj)
        {
            return Equals(obj as Estoque);
        }

        public bool Equals(Estoque? other)
        {
            return other is not null &&
                   Id == other.Id &&
                   Nome == other.Nome &&
                   Quantidade == other.Quantidade &&
                   Status == other.Status;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome, Quantidade, Status);
        }
        #endregion HashCode e Equals
    }
}
