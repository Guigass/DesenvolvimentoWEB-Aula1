using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fiap01.Controllers
{
    public class AutorController : Controller
    {
        public IActionResult Index(string nome)
        {
            return View();
        }

        public IActionResult ListaDosAutoresDoAno(int ano)
        {
            return View();
        }
    }
}