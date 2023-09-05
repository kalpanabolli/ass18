using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ass18.Models;

namespace Ass18.Data
{
    public class Ass18DbContext : DbContext
    {
        public Ass18DbContext (DbContextOptions<Ass18DbContext> options)
            : base(options)
        {
        }

        public DbSet<Ass18.Models.Movie> Movie { get; set; } = default!;
    }
}
