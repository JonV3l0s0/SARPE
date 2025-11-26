using Microsoft.AspNetCore.Mvc;
using SARPE.Contracts;
using SARPE.Extensions;
using SARPE.Models;
using SARPE.Services;

namespace SARPE.Controllers
{
    public class RelatorioDeClientesController : Controller
    {
        private readonly IClienteService _clienteService;

        public RelatorioDeClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet(Name = nameof(Index))]
        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            var todos = _clienteService.GetTodosOsClientesSalvos();
            var total = todos.Count();

            var clientesPaginados = todos
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var viewModel = new ClientePaginadoViewModel
            {
                Clientes = clientesPaginados,
                PaginaAtual = page,
                TamanhoPagina = pageSize,
                TotalItens = total
            };

            return View(viewModel);
        }


        [HttpGet(Name = nameof(Details))]
        public ActionResult Details(int id)
        {
            var cliente = _clienteService.GetClienteSalvoPorId(id);
            if (cliente is null)
                return RedirectToAction(nameof(Index));

            var clienteVm = cliente!.ToDetalheViewModel();
            return View(clienteVm);
        }
    }
}
