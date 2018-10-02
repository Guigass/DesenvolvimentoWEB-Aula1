using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap01.ViewComponents
{
    public class NoticiasViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int total, bool noticiasUrgentes)
        {
            string view = "noticias";

            if (total > 3 && noticiasUrgentes == true)
            {
                view = "noticiasurgentes";
            }

            var itens = GetItens(total);
            return View(view, itens);
        }

        private IEnumerable<Noticia> GetItens(int total)
        {
            for (int i = 0; i < total; i++)
            {
                yield return new Noticia() { Id = 1, Titulo = $"Noticia {i}", Link = $"http://{i}" };
            }
        }
    }

    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Link { get; set; }
    }
}
