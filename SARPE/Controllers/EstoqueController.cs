using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SARPE.Contracts;
using SARPE.DTO;
using SARPE.Extensions;

namespace SARPE.Controllers
{
    public class EstoqueController : Controller
    {

        private readonly IEstoqueService _estoqueService;

        public EstoqueController(IEstoqueService estoqueService)
        {
            _estoqueService = estoqueService;
        }

        [HttpGet(Name = nameof(Index))]
        public ActionResult Index()
        {
            var estoques = _estoqueService.GetTodosOsEstoques();
            return View(estoques);
        }

        [HttpGet(Name = nameof(Details))]
        public ActionResult Details(int id)
        {
            //fazer essa parte
        }

        [HttpPost(Name = nameof(Create))]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstoqueCriarDTO estoqueDTO)
        {
            if (estoqueDTO.Quantidade > 0) estoqueDTO.Status = Enums.EStatusEstoque.Disponivel;
            try
            {
                _estoqueService.SalvarEstoque(estoqueDTO);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View();
            }
        }

        [HttpPost(Name = nameof(Edit))]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EstoqueEditarDTO estoqueEditado)
        {
            try
            {
                _estoqueService.AtualizarEstoque(id, estoqueEditado);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet(Name = nameof(Delete))]
        public ActionResult Delete(int id)
        {
            try
            {
                _estoqueService.ExcluirEstoquePorId(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
