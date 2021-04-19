using Microsoft.EntityFrameworkCore;
using serwisy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serwisy.Data
{
    public class ProduktContext: DbContext
    {
        public ProduktContext(DbContextOptions options) : base(options) { }
        public DbSet<Produkt> Produkt { get; set; }

    }
}
