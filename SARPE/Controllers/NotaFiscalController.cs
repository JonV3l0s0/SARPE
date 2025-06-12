using Microsoft.AspNetCore.Mvc;
using SARPE.Contracts;
using SARPE.DTO;
using SARPE.Extensions;

namespace SARPE.Controllers
{
    public class NotaFiscalController : Controller
    {
        private readonly INotaFiscalService _notaFiscalService;

        public NotaFiscalController(INotaFiscalService service)
        {
            _notaFiscalService = service;
        }

        // GET: ProdutoController
        [HttpGet(Name = nameof(Index))]
        public IActionResult Index()
        {
            var notas = _notaFiscalService.GetTodasNotasFiscais();
            return View(notas);
        }

        // GET: ProdutoController/Details/5
        [HttpGet(Name = nameof(Details))]
        public ActionResult Details(int id)
        {
            var notaFiscal = _notaFiscalService.GetNotaFiscalPorId(id);

            if (notaFiscal is null)
                return RedirectToAction(nameof(Index));

            var nfVm = notaFiscal!.ToDetalheViewModel();
            return View(nfVm);
        }

        [HttpPost(Name = nameof(Create))]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NotaFiscalCriarDTO notaFiscalDTO)
        {
            try
            {
                _notaFiscalService.SalvarNotaFiscal(notaFiscalDTO);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost(Name = nameof(Edit))]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, NotaFiscalEditarDTO notaFiscalEditada)
        {
            try
            {
                _notaFiscalService.AtualizarNotaFiscal(id, notaFiscalEditada);
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
                _notaFiscalService.ExcluirNotaFiscalPorId(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}