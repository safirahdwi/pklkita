using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adminLTE.Models
{
    public class PrestasiContext : DbContext
    {
        public PrestasiContext(DbContextOptions<PrestasiContext> options) : base(options)
        {
        }

        public DbSet<Prestasi> Prestasis { get; set; }
    }
}