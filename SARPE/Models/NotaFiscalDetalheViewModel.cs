namespace SARPE.Models
{
    public class NotaFiscalDetalheViewModel
    {
        public int Id { get; set; }
        public int EntidadeId { get; set; }
        public int TipoNfId { get; set; }
        public string NumeroNf { get; set; } = string.Empty;
        public int SerieNf { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public decimal ValorNf { get; set; }
        public string Fornecedor { get; set; } = string.Empty;
    }
}
