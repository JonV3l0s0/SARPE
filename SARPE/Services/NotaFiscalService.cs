using SARPE.Contracts;
using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Services
{
    public class NotaFiscalService : INotaFiscalService
    {
        private readonly INotaFiscalRepository _notaFiscalRepository;

        public NotaFiscalService(INotaFiscalRepository notaFiscalRepository)
        {
            _notaFiscalRepository = notaFiscalRepository;
        }

        public void AtualizarNotaFiscal(int id, NotaFiscalEditarDTO dto)
        {
            var nf = GetNotaFiscalPorId(id);
            if (nf == null) return;
            nf.EntidadeId = dto.EntidadeId;
            nf.TipoNfId = dto.TipoNfId;
            nf.NumeroNf = dto.NumeroNf;
            nf.SerieNf = dto.SerieNf;
            nf.DataEmissao = dto.DataEmissao;
            nf.DataEntrada = dto.DataEntrada;
            nf.ValorNf = dto.ValorNf;
            nf.Fornecedor = dto.Fornecedor;
            _notaFiscalRepository.AtualizarNotaFiscal(nf);
        }

        public void ExcluirNotaFiscalPorId(int id)
        {
            _notaFiscalRepository.ExcluirNotaFiscalPorId(id);
        }

        public NotaFiscal? GetNotaFiscalPorId(int id)
        {
            return _notaFiscalRepository.GetNotaFiscalPorId(id);
        }

        public IEnumerable<NotaFiscal> GetTodasNotasFiscais()
        {
            return _notaFiscalRepository.GetTodasNotasFiscais();
        }

        public void SalvarNotaFiscal(NotaFiscalCriarDTO dto)
        {
            var id = GetTodasNotasFiscais().LastOrDefault()?.Id + 1 ?? 1;
            var nf = new NotaFiscal
            {
                Id = id,
                EntidadeId = dto.EntidadeId,
                TipoNfId = dto.TipoNfId,
                NumeroNf = dto.NumeroNf,
                SerieNf = dto.SerieNf,
                DataEmissao = dto.DataEmissao,
                DataEntrada = dto.DataEntrada,
                ValorNf = dto.ValorNf,
                Fornecedor = dto.Fornecedor
            };
            _notaFiscalRepository.SalvarNotaFiscal(nf);
        }
    }
}