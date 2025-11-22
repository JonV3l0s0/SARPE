using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Extensions
{
    public static class ProdutoExtensions
    {
        public static ProdutoDetalheViewModel ToDetalheViewModel(this Produto produto)
        {
            return new()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Quantidade = produto.Quantidade,
                Preco = produto.Preco,
                Lote = produto.Lote,
            };
        }

        public static ProdutoEditarDTO ToEditarDTO(this ProdutoDetalheViewModel produto)
        {
            return new()
            {
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Quantidade = produto.Quantidade,
                Preco = produto.Preco,
            };
        }
    }
}
