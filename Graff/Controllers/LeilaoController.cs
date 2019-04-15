using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Graff.Services;
using Graff.Models;
using Graff.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Graff.Controllers
{
    public class LeilaoController : Controller
    {
        private readonly LeilaoService _leilaoService;
        private readonly ProdutoService _produtoService;
        public LeilaoController(LeilaoService leilaoService, ProdutoService produtoService)
        {
            _leilaoService = leilaoService;
            _produtoService = produtoService;
        }
            
        public IActionResult Index()
        {
            var list = _leilaoService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var produtos = _produtoService.FindAll();
            var viewmodel = new LeilaoFormViewModel { Produtos = produtos };
            return View(viewmodel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Leilao leilao)
        {
            _leilaoService.Insert(leilao);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _leilaoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

    }
}