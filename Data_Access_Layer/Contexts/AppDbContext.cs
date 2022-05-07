using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Contexts
{
    public class AppDbContext:DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("server=.;Database= CompanyRepository;Trusted_Connection = True;MultipleActiveResultSets = True");
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Department> Departments { get; set;}

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<District> Districts { get; set; }
    }
}
