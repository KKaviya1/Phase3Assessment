using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMSFullStackApp.Models;

namespace EMSFullStackApp.Data
{
    public class SimplonaDbContext : DbContext
    {
        public SimplonaDbContext (DbContextOptions<SimplonaDbContext> options)
            : base(options)
        {
        }

        public DbSet<EMSFullStackApp.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<EMSFullStackApp.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
