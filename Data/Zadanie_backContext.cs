using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zadanie_back.Models;

namespace Zadanie_back.Data
{
    public class Zadanie_backContext : DbContext
    {
        public Zadanie_backContext (DbContextOptions<Zadanie_backContext> options)
            : base(options)
        {
        }

        public DbSet<Zadanie_back.Models.Movie> Movie { get; set; } = default!;
    }
}
