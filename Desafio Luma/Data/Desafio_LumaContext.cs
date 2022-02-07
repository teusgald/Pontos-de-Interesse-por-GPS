using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Desafio_Luma.Models;

namespace Desafio_Luma.Data
{
    public class Desafio_LumaContext : DbContext
    {
        public Desafio_LumaContext (DbContextOptions<Desafio_LumaContext> options)
            : base(options)
        {
        }

        public DbSet<Desafio_Luma.Models.Local> Local { get; set; }
    }
}
