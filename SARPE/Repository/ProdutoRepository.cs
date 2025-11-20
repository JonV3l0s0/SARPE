using SARPE.Contracts;
using SARPE.Models;
using System.Diagnostics;

namespace SARPE.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly static List<Produto> _produtos = [];

        public void AtualizarProduto(Produto produto)
        {
            try
            {
                var produtoAAtualizar = GetProdutoPorId(produto.Id);
                produtoAAtualizar.Nome = produto.Nome;
                produtoAAtualizar.Descricao = produto.Descricao;
                produtoAAtualizar.Preco = produto.Preco;

                Debug.WriteLine("Produto Atualizado com sucesso!");
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro ao atualizar o produto");
                throw;
            }

        }

        public void ExcluirProdutoPorId(int id)
        {
            try
            {
                var produto = GetProdutoPorId(id);

                if (produto is null)
                    return;

                _produtos.Remove(produto);

                Debug.WriteLine("Produto Excluido com sucesso!");
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro ao excluir o produto");
                throw;
            }
        }

        public void ExcluirTodosOsProdutos()
        {
            try
            {

                if(!_produtos.Any()) return;

                _produtos.Clear();

                Debug.WriteLine("Todos os produtos foram excluídos!");
            }
            catch
            {
                Debug.WriteLine("Erro ao excluir todos os produtos!");
                throw;
            }
        }

        public Produto? GetProdutoPorId(int id)
        {
           return _produtos.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Produto> GetTodosOsProdutos()
        {
            return _produtos;
        }

        public void SalvarProduto(Produto produto)
        {
            try
            {
                _produtos.Add(produto);
                Debug.WriteLine("Produto Salvo com sucesso!");
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro ao salvar produto no banco de dados.");
                throw;
            }
        }
    }
}
