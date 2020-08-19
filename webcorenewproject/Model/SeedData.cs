using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webcorenewproject.Model
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder model)
        {
            model.Entity<Employeecs>().HasData(new Employeecs {
            Id=1,
            Name="Amit Chauhan",
            Age=38,
            Address="381, Khuda Ali sher Chandigarh"
            },
            
            new Employeecs { 
            Id=2,
            Name="Aarti Chauhan",
            Age=31,
            Address="381, Khauda Ali Sher Chandigarh"
            });
        }
    }
}
