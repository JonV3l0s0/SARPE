

using SARPE.DTO;
using System.Diagnostics;

namespace SARPE.Models
{
    public class Produto
    {
        public int Id { get;  set; }
        public string CodigoDeBarras { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int Quantidade { get; set; } = 0;
        public float Preco { get; set; }
        public string Lote { get; set; } = string.Empty;

        #region Construtor
        public Produto(string codigoDeBarras, string nome, string descricao, int quantidade,float preco, string lote)
        {
            CodigoDeBarras = codigoDeBarras;
            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
            Lote = lote;
        }

        public Produto(int id, string codigoDeBarras, string nome, string descricao, int quantidade, float preco, string lote)
        {
            Id = id;
            CodigoDeBarras = codigoDeBarras;
            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
            Lote = lote;
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
