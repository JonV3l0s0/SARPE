using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Extensions
{
    public static class NotaFiscalExtensions
    {
        public static NotaFiscalDetalheViewModel ToDetalheViewModel(this NotaFiscal nf)
        {
            return new()
            {
                Id = nf.Id,
                EntidadeId = nf.EntidadeId,
                TipoNfId = nf.TipoNfId,
                NumeroNf = nf.NumeroNf,
                SerieNf = nf.SerieNf,
                DataEmissao = nf.DataEmissao,
                DataEntrada = nf.DataEntrada,
                ValorNf = nf.ValorNf,
                Fornecedor = nf.Fornecedor

            };
        }

        public static NotaFiscalEditarDTO ToEditarDTO(this NotaFiscalDetalheViewModel nf)
        {
            return new()
            {
                Id = nf.Id,
                EntidadeId = nf.EntidadeId,
                TipoNfId = nf.TipoNfId,
                NumeroNf = nf.NumeroNf,
                SerieNf = nf.SerieNf,
                DataEmissao = nf.DataEmissao,
                DataEntrada = nf.DataEntrada,
                ValorNf = nf.ValorNf,
                Fornecedor = nf.Fornecedor

            };
        }
    }
}
