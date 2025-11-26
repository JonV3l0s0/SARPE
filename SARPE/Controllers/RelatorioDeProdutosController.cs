using Microsoft.AspNetCore.Mvc;
using SARPE.Contracts;
using SARPE.Extensions;
using SARPE.Models;

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
        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            var todos = _produtoService.GetTodosOsProdutosSalvos();
            var totalItems = todos.Count();
            var produtosPaginados = todos
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var viewModel = new ProdutoPaginadoViewModel
            {
                Produtos = produtosPaginados,
                PaginaAtual = page,
                TotalItens = totalItems,
                TamanhoPagina = pageSize
            };

            return View(viewModel);
        }


        public ActionResult Details(int id)
        {
            var produto = _produtoService.GetProdutoSalvoPorId(id);

            if (produto is null)
                RedirectToAction(nameof(Index));

            var produtoVM = produto!.ToDetalheViewModel();
            return View(produtoVM);
        }
    }
}
