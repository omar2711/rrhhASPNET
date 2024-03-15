using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rrhh2.Models;

namespace rrhh2.Data
{
    public class rrhh2Context : DbContext
    {
        public rrhh2Context (DbContextOptions<rrhh2Context> options)
            : base(options)
        {
        }

        public DbSet<rrhh2.Models.Department> Department { get; set; } = default!;
        public DbSet<rrhh2.Models.Position> Position { get; set; } = default!;
        public DbSet<rrhh2.Models.Employee> Employee { get; set; } = default!;
    }
}
