using SARPE.Models;

namespace SARPE.Contracts
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetTodosOsProdutos();
        IEnumerable<Produto> GetTodosOsProdutosSalvos();
        Produto? GetProdutoPorId(int id);
        Produto? GetProdutoSalvoPorId(int id);
        void SalvarProduto(Produto produto);
        void SalvarTodosOsProdutos();
        void AtualizarProduto(Produto produto);
        void ExcluirProdutoPorId(int id);
        void ExcluirTodosOsProdutos();
    }
}
