
namespace SARPE.Models
{
    public class ProdutoDetalheViewModel
    {
        public int Id { get; set; }
        public string Nome { get;  set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Lote { get; set; } = string.Empty;
        public float Preco { get;  set; }
    }
}
