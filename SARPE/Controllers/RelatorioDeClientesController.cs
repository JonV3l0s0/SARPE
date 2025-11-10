using Microsoft.AspNetCore.Mvc;
using SARPE.Contracts;
using SARPE.Extensions;
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
        public IActionResult Index()
        {
            var clientes = _clienteService.GetTodosOsClientes();
            return View(clientes);
        }

        [HttpGet(Name = nameof(Details))]
        public ActionResult Details(int id)
        {
            var cliente = _clienteService.GetClientePorId(id);
            if (cliente is null)
                return RedirectToAction(nameof(Index));

            var clienteVm = cliente!.ToDetalheViewModel();
            return View(clienteVm);
        }
    }
}
