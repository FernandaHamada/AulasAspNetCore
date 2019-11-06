using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AulasAspNetCore.Models
{
    public class AulasAspNetCoreContext : DbContext
    {
        public AulasAspNetCoreContext (DbContextOptions<AulasAspNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<AulasAspNetCore.Models.Department> Department { get; set; }
    }
}
