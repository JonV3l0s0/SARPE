

using SARPE.DTO;
using System.Diagnostics;

namespace SARPE.Models
{
    public class Produto : IEquatable<Produto?>
    {
        public int Id { get;  set; }
        public Estoque? EstoqueId { get; set; } 
        public string CodigoDeBarras { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public float Preco { get; set; }
        public string Lote { get; set; } = string.Empty;

        #region Construtor
        public Produto(string codigoDeBarras, string nome, string descricao, float preco, string lote)
        {
            CodigoDeBarras = codigoDeBarras;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Lote = lote;
        }

        // Construtor com Id para fins de teste
        public Produto(int id, string codigoDeBarras, string nome, string descricao, float preco, string lote)
        {
            Id = id;
            CodigoDeBarras = codigoDeBarras;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Lote = lote;
        }

        // Provavelmente precisa-se de construtor sem argumentos por conta do EntityFramework
        // obs: Averiguar essa informação
        public Produto()
        {
        }
        #endregion

        #region HashCode e Equals
        public override bool Equals(object? obj)
        {
            return Equals(obj as Produto);
        }

        public bool Equals(Produto? other)
        {
            return other is not null &&
                   Id == other.Id &&
                   CodigoDeBarras == other.CodigoDeBarras;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CodigoDeBarras);
        }
        #endregion

    }
}
