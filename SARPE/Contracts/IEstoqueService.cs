using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Contracts
{
    public interface IEstoqueService
    {
        IEnumerable<Estoque> GetTodosOsEstoques();
        Estoque? GetEstoquePorId(int id);
        void SalvarEstoque(EstoqueCriarDTO estoqueDTO);
        void AtualizarEstoque(int id, EstoqueEditarDTO estoqueDTO);
        void ExcluirEstoquePorId(int id);
        void ExcluirTodoOEstoque();
    }
}
