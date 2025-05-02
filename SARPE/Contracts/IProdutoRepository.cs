using SARPE.Models;

namespace SARPE.Contracts
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetTodosOsProdutos();
        Produto? GetProdutoPorId(int id);
        void SalvarProduto(Produto produto);
        void AtualizarProduto(Produto produto);
        void ExcluirProdutoPorId(int id);
    }
}
