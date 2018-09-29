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
        public IActionResult Index()
        {
            ViewBag.Nome = "Guilherme";

            ViewData["DataAgora"] = $"A Data é {DateTime.Now.ToString()}";

            var pergunta = new Pergunta
            {
                Id = 0,
                Autor = "Daniel",
                Descricao = "Que horas é a chamada?"
            };

            return View(pergunta);
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
