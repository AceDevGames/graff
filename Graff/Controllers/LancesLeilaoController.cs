using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Graff.Services;
using Graff.Models;
using Graff.Models.ViewModels;

namespace Graff.Controllers
{
    public class LancesLeilaoController : Controller
    {
        private readonly LancesLeilaoService _lancesLeilaoService;
        private readonly PessoaService _pessoaService;
        private readonly LeilaoService _leilaoService;
        private readonly ProdutoService _produtoService;
        public LancesLeilaoController(LancesLeilaoService lancesLeilaoService, PessoaService pessoaService, LeilaoService leilaoService, ProdutoService produtoService)
        {
            _lancesLeilaoService = lancesLeilaoService;
            _pessoaService = pessoaService;
            _leilaoService = leilaoService;
            _produtoService = produtoService;
        }
        public IActionResult Index()
        {
            var list = _lancesLeilaoService.FindAll();
            return View(list);
        }
        public IActionResult Create(int id)
        {
            var pessoas = _pessoaService.FindAll();
            var leiloes = _leilaoService.FindAll();
            var produtos = _produtoService.FindAll();
            var viewmodel = new LancesLeilaoFormViewModel {Pessoas = pessoas, Leiloes = leiloes, Produtos = produtos};
            return View(viewmodel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LancesLeilao lancesLeilao)
        {
            LancesLeilao ll = new LancesLeilao();
           // ll.id = id;
            //if(lancesLeilao.valor < )
            _lancesLeilaoService.Insert(lancesLeilao);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _lancesLeilaoService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

       public IActionResult Delete(int id)
        {
           // _lancesLeilaoService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}