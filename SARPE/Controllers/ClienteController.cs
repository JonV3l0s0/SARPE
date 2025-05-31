using Microsoft.AspNetCore.Mvc;
using SARPE.Contracts;
using SARPE.DTO;
using SARPE.Extensions;

namespace SARPE.Controllers
{
    public class ClienteController : Controller
    {

        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet(Name = nameof(Index))]
        public ActionResult Index()
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

        [HttpPost(Name = nameof(Create))]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteCriarDTO clienteDTO)
        {
            try
            {
                _clienteService.SalvarCliente(clienteDTO);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost(Name = nameof(Edit))]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClienteEditarDTO clienteEditado)
        {
            try
            {
                _clienteService.AtualizarCliente(id, clienteEditado);
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
                _clienteService.ExcluirClientePorId(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
