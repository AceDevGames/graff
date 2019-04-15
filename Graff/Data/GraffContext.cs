using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Graff.Models
{
    public class GraffContext : DbContext
    {
        public GraffContext (DbContextOptions<GraffContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Leilao> Leilao { get; set; }
        public DbSet<LancesLeilao> LancesLeilao { get; set; }
    }
}
