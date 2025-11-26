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
            produto.Quantidade = produtoDTO.Quantidade;
            produto.Preco = produtoDTO.Preco;
            produto.Lote = produtoDTO.Lote;

            _produtoRepository.AtualizarProduto(produto);
        }

        public void ExcluirProdutoPorId(int id)
        {
            _produtoRepository.ExcluirProdutoPorId(id);
        }

        public void ExcluirTodosOsProdutos()
        {
                _produtoRepository.ExcluirTodosOsProdutos();
        }

        public Produto? GetProdutoPorId(int id)
        {
           var produto = _produtoRepository.GetProdutoPorId(id);
           return produto;
        }
        public Produto? GetProdutoSalvoPorId(int id)
        {
           var produto = _produtoRepository.GetProdutoSalvoPorId(id);
           return produto;
        }

        public IEnumerable<Produto> GetTodosOsProdutos()
        {
            var todosOsProdutos = _produtoRepository.GetTodosOsProdutos();
            return todosOsProdutos;
        }

        public IEnumerable<Produto> GetTodosOsProdutosSalvos()
        {
            var todosOsProdutosSalvos = _produtoRepository.GetTodosOsProdutosSalvos();
            return todosOsProdutosSalvos;
        }

        public void SalvarProduto(ProdutoCriarDTO produtoDTO)
        {
            var produto = new Produto
            (
                0,
                produtoDTO.CodigoDeBarras,
                produtoDTO.Nome,
                produtoDTO.Descricao,
                produtoDTO.Quantidade,
                produtoDTO.Preco,
                produtoDTO.Lote
            );

            _produtoRepository.SalvarProduto(produto);
        }

        public void SalvarTodosOsProdutos()
        {
            _produtoRepository.SalvarTodosOsProdutos();
        }
    }
}
