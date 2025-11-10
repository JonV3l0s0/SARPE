using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Contracts
{
    public interface INotaFiscalService
    {
        IEnumerable<NotaFiscal> GetTodasNotasFiscais();
        NotaFiscal? GetNotaFiscalPorId(int id);
        void SalvarNotaFiscal(NotaFiscalCriarDTO notaFiscalDTO);
        void AtualizarNotaFiscal(int id, NotaFiscalEditarDTO notaFiscalDTO);
        void ExcluirNotaFiscalPorId(int id);
    }
}
