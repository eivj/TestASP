using System;
using TestASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace TestASP.Context
{
    public class CatContext : DbContext
    {   
        public DbSet<Cat> cats { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CatalogsOfCats;Trusted_Connection=True; MultipleActiveResultSets=True;");
            
           
        }
    }
}
