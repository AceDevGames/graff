using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Graff.Models;
using Graff.Services;
using Microsoft.AspNetCore.Mvc;

namespace Graff.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoaService _pessoaService;
        public PessoasController(PessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }


        public IActionResult Index()
        {
            var list = _pessoaService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pessoa pessoa)
        {
            _pessoaService.Insert(pessoa);
            return RedirectToAction(nameof(Index));
        }
    }
}