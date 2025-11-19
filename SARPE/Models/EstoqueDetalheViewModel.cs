using SARPE.Enums;

namespace SARPE.Models
{
    public class EstoqueDetalheViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public long Quantidade { get; set; } = 0;
        public EStatusEstoque Status { get; set; } = EStatusEstoque.Indisponivel;
    }
}
