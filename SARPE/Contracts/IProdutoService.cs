using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Contracts
{
    public interface IProdutoService
    {
        IEnumerable<Produto> GetTodosOsProdutos();
        Produto? GetProdutoPorId(int id);
        void SalvarProduto(ProdutoCriarDTO produtoDTO);
        void AtualizarProduto(int id, ProdutoEditarDTO produtoDTO);
        void ExcluirProdutoPorId(int id);
        void ExcluirTodosOsProdutos();
    }
}
