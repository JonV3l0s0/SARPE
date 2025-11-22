using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Contracts
{
    public interface IProdutoService
    {
        IEnumerable<Produto> GetTodosOsProdutos();
        IEnumerable<Produto> GetTodosOsProdutosSalvos();
        Produto? GetProdutoPorId(int id);
        Produto? GetProdutoSalvoPorId(int id);
        void SalvarProduto(ProdutoCriarDTO produtoDTO);
        void SalvarTodosOsProdutos();
        void AtualizarProduto(int id, ProdutoEditarDTO produtoDTO);
        void ExcluirProdutoPorId(int id);
        void ExcluirTodosOsProdutos();
    }
}
