

namespace SARPE.Models
{
    public class Produto : IEquatable<Produto?>
    {
        public int Id { get;  set; }
        public Estoque? EstoqueId { get; set; } 
        public string CodigoDeBarras { get; private set; } = string.Empty;
        public string Nome { get; private set; } = string.Empty;
        public string Descricao { get; private set; } = string.Empty;
        public float Preco { get; private set; }
        public string Lote { get; private set; } = string.Empty;


        public Produto(string codigoDeBarras, string nome, string descricao, float preco, string lote)
        {
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

    }
}
