using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Required.Models;

namespace Required.Data
{
    public class RequiredContext : DbContext
    {
        public RequiredContext (DbContextOptions<RequiredContext> options)
            : base(options)
        {
        }

        public DbSet<Required.Models.Superhero> Superhero { get; set; }
    }
}
