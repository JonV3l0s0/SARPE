using System;

namespace SARPE.Models
{
    public class NotaFiscal
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

        #region Construtor
        public NotaFiscal()
        {
                
        }

        //para testes
        public NotaFiscal(int id, int entidadeId, int tipoNfId, string numeroNf, int serieNf, DateTime dataEmissao, DateTime dataEntrada, decimal valorNf, string fornecedor)
        {
            Id = id;
            EntidadeId = entidadeId;
            TipoNfId = tipoNfId;
            NumeroNf = numeroNf;
            SerieNf = serieNf;
            DataEmissao = dataEmissao;
            DataEntrada = dataEntrada;
            ValorNf = valorNf;
            Fornecedor = fornecedor;
        }

        public NotaFiscal(int entidadeId, int tipoNfId, string numeroNf, int serieNf, DateTime dataEmissao, DateTime dataEntrada, decimal valorNf, string fornecedor)
        {
            EntidadeId = entidadeId;
            TipoNfId = tipoNfId;
            NumeroNf = numeroNf;
            SerieNf = serieNf;
            DataEmissao = dataEmissao;
            DataEntrada = dataEntrada;
            ValorNf = valorNf;
            Fornecedor = fornecedor;
        }

        #endregion Construtor

        #region HashCode e Equals
        public override bool Equals(object? obj)
        {
            return Equals(obj as NotaFiscal);
        }

        public bool Equals(NotaFiscal? other)
        {
            return other is not null &&
                Id == other.Id &&
                NumeroNf == other.NumeroNf &&
                SerieNf == other.SerieNf &&
                Fornecedor == other.Fornecedor;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, NumeroNf, SerieNf, Fornecedor);
        }
        #endregion HashCode e Equals
    }
}