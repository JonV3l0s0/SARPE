using SARPE.Contracts;
using SARPE.Models;
using System.Diagnostics;

namespace SARPE.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly static List<Produto> _produtos =
        [
             new(1, "00001", "TV TCL 55C655", "Aparelho audiovisual", 2300.0f, "XPTO"),
             new(2, "00002", "TV Samsung Q43N90D", "Aparelho audiovisual", 2300.0f, "XPTO"),
             new(3, "00003", "TV LG Crystal", "Aparelho audiovisual", 2300.0f, "XPTO"),
        ];

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
