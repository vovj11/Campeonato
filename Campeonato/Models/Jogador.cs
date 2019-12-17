using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Campeonato.Models
{
    public class Jogador
    {
        [Display(Name = "código")]
        public int JogadorId { get; set; }

        [Required(ErrorMessage = "Campo Nome deve ser preenchido", AllowEmptyStrings = false)]
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Campo Idade deve ser preenchido", AllowEmptyStrings = false)]
        [Display(Name = "Idade")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo Nacionalidade deve ser preenchido", AllowEmptyStrings = false)]
        [Display(Name = "Nacionalidade")]
        public String Nacionalidade { get; set; }

        public ICollection<Placar> Placares { get; set; }
    }
}
