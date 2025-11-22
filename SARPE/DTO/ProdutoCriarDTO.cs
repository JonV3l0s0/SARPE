using SARPE.Models;

namespace SARPE.DTO
{
    public class ProdutoCriarDTO
    {
        public string CodigoDeBarras { get;  set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int Quantidade { get; set; } = 0;
        public float Preco { get; set; }
        public string Lote { get;  set; } = string.Empty;
    }
}
