using SARPE.Contracts;
using SARPE.DTO;
using SARPE.Models;

namespace SARPE.Services
{
    public class EstoqueService : IEstoqueService
    {

        private readonly IEstoqueRepository _estoqueRepository;

        public EstoqueService(IEstoqueRepository estoqueRepository)
        {
            _estoqueRepository = estoqueRepository;
        }

        public void AtualizarEstoque(int id, EstoqueEditarDTO estoqueDTO)
        {
            var estoque = GetEstoquePorId(id);
            if (estoque == null)
                return;
            estoque.Nome = estoqueDTO.Nome;
            estoque.Quantidade = estoqueDTO.Quantidade;
            estoque.Status = estoqueDTO.Status;

            _estoqueRepository.AtualizarEstoque(estoque);
        }

        public void ExcluirEstoquePorId(int id)
        {
            _estoqueRepository.ExcluirEstoquePorId(id);
        }

        public Estoque? GetEstoquePorId(int id)
        {
            var estoque = _estoqueRepository.GetEstoquePorId(id);
            return estoque;
        }

        public IEnumerable<Estoque> GetTodosOsEstoques()
        {
            var todosOsEstoques = _estoqueRepository.GetTodosOsEstoques();
            return todosOsEstoques;
        }

        public void SalvarEstoque(EstoqueCriarDTO estoqueDTO)
        {
            var id = GetTodosOsEstoques().Count() == 0 ? 0 : GetTodosOsEstoques().Last().Id + 5;

            var estoque = new Estoque
                (
                id,
                estoqueDTO.Nome,
                estoqueDTO.Quantidade,
                estoqueDTO.Status
                );

            _estoqueRepository.SalvarEstoque(estoque);
        }
    }
}
