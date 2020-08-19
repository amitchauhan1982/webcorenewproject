using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webcorenewproject.Model
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options):base(options)
        {

        }
        public DbSet<Employeecs> Employee { get; set; }

       protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.Seed();
        }
    }
}
