using SARPE.Contracts;
using SARPE.DTO;
using SARPE.Models;
using SARPE.Repository;

namespace SARPE.Services
{
    public class ProdutoService: IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService (IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void AtualizarProduto(int id, ProdutoEditarDTO produtoDTO)
        {
            var produto = GetProdutoPorId(id);

            if (produto == null)
                return;
                        
            produto.Nome = produtoDTO.Nome;
            produto.Descricao = produtoDTO.Descricao;
            produto.Preco = produtoDTO.Preco;

            _produtoRepository.AtualizarProduto(produto);
        }

        public void ExcluirProdutoPorId(int id)
        {
            _produtoRepository.ExcluirProdutoPorId(id);
        }

        public Produto? GetProdutoPorId(int id)
        {
           var produto = _produtoRepository.GetProdutoPorId(id);
           return produto;
        }

        public IEnumerable<Produto> GetTodosOsProdutos()
        {
            var todosOsProdutos = _produtoRepository.GetTodosOsProdutos();
            return todosOsProdutos;
        }

        public void SalvarProduto(ProdutoCriarDTO produtoDTO)
        {
            var id = GetTodosOsProdutos().Last().Id + 5;

            var produto = new Produto
            (
                id,
                produtoDTO.CodigoDeBarras,
                produtoDTO.Nome,
                produtoDTO.Descricao,
                produtoDTO.Preco,
                produtoDTO.Lote
            );

            _produtoRepository.SalvarProduto(produto);
        }
    }
}
