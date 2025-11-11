using SARPE.Contracts;
using SARPE.Models;
using System.Diagnostics;

namespace SARPE.Repository
{
    public class NotaFiscalRepository : INotaFiscalRepository
    {
        private static readonly List<NotaFiscal> _notasFiscais = [
            new(1,1,1,"15555",545,new DateTime(2020,7,4),DateTime.Now,1555.0m,"Zezinho"),
            new(2,1,1,"15554",545,new DateTime(2025,4,4),DateTime.Now,1555.0m,"Zezinho1"),
            new(3,1,1,"15556",545,DateTime.Now,DateTime.Now,1555.0m,"Zezinho2"),
            ];

        public void AtualizarNotaFiscal(NotaFiscal notaFiscal)
        {
            var nf = GetNotaFiscalPorId(notaFiscal.Id);
            if (nf == null) return;
            nf.EntidadeId = notaFiscal.EntidadeId;
            nf.TipoNfId = notaFiscal.TipoNfId;
            nf.NumeroNf = notaFiscal.NumeroNf;
            nf.SerieNf = notaFiscal.SerieNf;
            nf.DataEmissao = notaFiscal.DataEmissao;
            nf.DataEntrada = notaFiscal.DataEntrada;
            nf.ValorNf = notaFiscal.ValorNf;
            nf.Fornecedor = notaFiscal.Fornecedor;
        }

        public void ExcluirNotaFiscalPorId(int id)
        {
            var nf = GetNotaFiscalPorId(id);
            if (nf != null) _notasFiscais.Remove(nf);
        }

        public NotaFiscal? GetNotaFiscalPorId(int id)
        {
            return _notasFiscais.FirstOrDefault(n => n.Id == id);
        }

        public IEnumerable<NotaFiscal> GetTodasNotasFiscais()
        {
            return _notasFiscais;
        }

        public void SalvarNotaFiscal(NotaFiscal notaFiscal)
        {
            _notasFiscais.Add(notaFiscal);
        }
    }
}