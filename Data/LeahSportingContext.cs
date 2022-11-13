using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeahSporting.Models;

namespace LeahSporting.Data
{
    public class LeahSportingContext : DbContext
    {
        public LeahSportingContext (DbContextOptions<LeahSportingContext> options)
            : base(options)
        {
        }

        public DbSet<LeahSporting.Models.Products> Products { get; set; } = default!;
    }
}
