using SARPE.Contracts;
using SARPE.Models;
using System.Diagnostics;

namespace SARPE.Repository
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly static List<Estoque> _estoques = [];

        public void AtualizarEstoque(Estoque estoque)
        {
            try
            {
                var estoqueAAlterar = GetEstoquePorId(estoque.Id);
                estoqueAAlterar.Nome = estoque.Nome;
                estoqueAAlterar.Quantidade = estoque.Quantidade;
                estoqueAAlterar.Status = estoque.Status;
                Debug.WriteLine("Estoque atualizado com sucesso!");
            }
            catch
            {
                Debug.WriteLine("Erro ao atualizar estoque!");
                throw;
            }
        }

        public void ExcluirEstoquePorId(int id)
        {
            try
            {
                var estoque = GetEstoquePorId(id);
                if (estoque is null) return;
                _estoques.Remove(estoque);
                Debug.WriteLine("Estoque excluído com sucesso!");
            }
            catch
            {
                Debug.WriteLine("Erro ao excluir estoque!");
                throw;
            }
        }

        public Estoque? GetEstoquePorId(int id)
        {
            return _estoques.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Estoque> GetTodosOsEstoques()
        {
            return _estoques;
        }

        public void SalvarEstoque(Estoque estoque)
        {
            try
            {
                _estoques.Add(estoque);
                Debug.WriteLine("Estoque salvo com sucesso!");
            }
            catch
            {
                Debug.WriteLine("Erro ao salvar estoque!");
                throw;
            }
        }
    }
}
