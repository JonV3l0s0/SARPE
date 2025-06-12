using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SARPE.Contracts;
using SARPE.DTO;
using SARPE.Extensions;
using SARPE.Models;

namespace SARPE.Controllers
{
    public class ProdutoController : Controller
    {
        
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }


        // GET: ProdutoController
        [HttpGet(Name = nameof(Index))]
        public ActionResult Index()
        {
            var produtos = _produtoService.GetTodosOsProdutos();
            return View(produtos);
        }

        // GET: ProdutoController/Details/5
        [HttpGet(Name = nameof(Details))]
        public ActionResult Details(int id)
        {
            var produto = _produtoService.GetProdutoPorId(id);

            if(produto is null)
                return RedirectToAction(nameof(Index));

            var produtoVM = produto!.ToDetalheViewModel();
            return View(produtoVM);
        }


        [HttpPost(Name = nameof(Create))]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoCriarDTO produtoDTO)
        {
            try
            {   
                _produtoService.SalvarProduto(produtoDTO);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost(Name = nameof(Edit))]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProdutoEditarDTO produtoEditado)
        {
            try
            {               
                _produtoService.AtualizarProduto(id, produtoEditado);
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
                _produtoService.ExcluirProdutoPorId(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
