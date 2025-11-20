using SARPE.Models;

namespace SARPE.Contracts
{
    public interface IEstoqueRepository
    {
        IEnumerable<Estoque> GetTodosOsEstoques();
        Estoque? GetEstoquePorId(int id);
        void SalvarEstoque(Estoque estoque);
        void AtualizarEstoque(Estoque estoque);
        void ExcluirEstoquePorId(int id);
        void ExcluirTodoOEstoque();
    }
}
