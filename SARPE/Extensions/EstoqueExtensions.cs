using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Extensions
{
    public static class EstoqueExtensions
    {
        public static EstoqueDetalheViewModel ToDetalheViewModel(this Estoque estoque)
        {
            return new()
            {
                Id = estoque.Id,
                Nome = estoque.Nome,
                Quantidade = estoque.Quantidade,
                Status = estoque.Status
            };
        }

        public static EstoqueEditarDTO ToEditarDTO(this EstoqueDetalheViewModel estoque)
        { 
            return new()
            {
                Nome = estoque.Nome,
                Quantidade = estoque.Quantidade,
                Status = estoque.Status
            };
        }
    }
}
