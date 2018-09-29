using Fiap01.Data;
using Fiap01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap01.Controllers
{
    public class HomeController : Controller
    {
        private PerguntasContext _context;
        public HomeController(PerguntasContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Perguntas.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pergunta pergunta)
        {
            if (ModelState.IsValid)
            {
                _context.Perguntas.Add(pergunta);

                await _context.SaveChangesAsync();

                ViewBag.status = "ok";
            }

            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }
        public IActionResult Sobre()
        {
            return View();
        }
    }
}
