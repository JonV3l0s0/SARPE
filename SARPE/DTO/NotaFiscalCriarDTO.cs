using System;

namespace SARPE.DTO
{
    public class NotaFiscalCriarDTO
    {
        public int EntidadeId { get; set; }
        public int TipoNfId { get; set; }
        public string NumeroNf { get; set; } = string.Empty;
        public int SerieNf { get; set; }
        public DateTime DataEmissao { get; set; } = DateTime.Now;
        public DateTime DataEntrada { get; set; } = DateTime.Now;
        public decimal ValorNf { get; set; }
        public string Fornecedor { get; set; } = string.Empty;
    }
}