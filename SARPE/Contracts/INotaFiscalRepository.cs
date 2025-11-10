using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Contracts
{
    public interface INotaFiscalRepository
    {
        IEnumerable<NotaFiscal> GetTodasNotasFiscais();
        NotaFiscal? GetNotaFiscalPorId(int id);
        void SalvarNotaFiscal(NotaFiscal notaFiscal);
        void AtualizarNotaFiscal(NotaFiscal notaFiscal);
        void ExcluirNotaFiscalPorId(int id);
    }
}
