using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap01.Models
{
    public class Pergunta
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo descrição obrigatorio")]
        public string Descricao { get; set; }
        public string Autor { get; set; }
    }
}
