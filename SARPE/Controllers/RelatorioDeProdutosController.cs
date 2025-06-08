using Microsoft.AspNetCore.Mvc;
using SARPE.Contracts;
using SARPE.Extensions;

namespace SARPE.Controllers
{
    public class RelatorioDeProdutosController : Controller
    {
        private readonly IProdutoService _produtoService;

        public RelatorioDeProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet(Name = nameof(Index))]
        public IActionResult Index()
        {
            var produtos = _produtoService.GetTodosOsProdutos();
            return View(produtos);
        }

        public ActionResult Details(int id)
        {
            var produto = _produtoService.GetProdutoPorId(id);

            if (produto is null)
                RedirectToAction(nameof(Index));

            var produtoVM = produto!.ToDetalheViewModel();
            return View(produtoVM);
        }
    }
}
