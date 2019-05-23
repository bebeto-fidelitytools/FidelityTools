using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FidelityTools.Models;

namespace FidelityTools.Models
{
    public class FidelityToolsContext : DbContext
    {
        public FidelityToolsContext (DbContextOptions<FidelityToolsContext> options)
            : base(options)
        {
        }

        public DbSet<FidelityTools.Models.Categorias> Categorias { get; set; }

        public DbSet<FidelityTools.Models.Productos> Productos { get; set; }
    }
}
