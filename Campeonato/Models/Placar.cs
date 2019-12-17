using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Campeonato.Models
{
    public class Placar
    {
        [Display(Name = "código")]
        public int PlacarId { get; set; }

        [Display(Name = "Jogador")]
        public int JogadorId { get; set; }

        [Display(Name = "Jogador")]
        public Jogador Jogador { get; set; }

        [Required(ErrorMessage = "Informe o total de pontos", AllowEmptyStrings = false)]
        [Display(Name = "Total de pontos")]
        [Range(0, int.MaxValue, ErrorMessage = "Informe só valores positivos")]
        public int TotalPontos { get; set; }

        [Required(ErrorMessage = "Campo Horario deve ser preenchido", AllowEmptyStrings = false)]
        [Display(Name = "Horário")]
        public DateTime HorarioId { get; set; }

    }
}
