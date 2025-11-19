using SARPE.Enums;

namespace SARPE.DTO
{
    public class EstoqueEditarDTO
    {
        public string Nome { get; set; } = string.Empty;
        public long Quantidade { get; set; } = 0;
        public EStatusEstoque Status { get; set; } = EStatusEstoque.Indisponivel;
    }
}
