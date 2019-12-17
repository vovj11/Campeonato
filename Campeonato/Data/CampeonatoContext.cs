using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Campeonato.Models;

namespace Campeonato.Data
{
    public class CampeonatoContext : DbContext
    {
        public CampeonatoContext (DbContextOptions<CampeonatoContext> options)
            : base(options)
        {
        }

        public DbSet<Campeonato.Models.Placar> Placar { get; set; }

        public DbSet<Campeonato.Models.Jogador> Jogador { get; set; }
    }
}
