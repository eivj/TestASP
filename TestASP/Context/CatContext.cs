using System.Data.Entity;
using TestASP.Models;

namespace TestASP.Context
{
    public class CatContext : DbContext
    {
        public CatContext()
            : base("DbConection")
        {

        }

        public DbSet<Cat> cats { get; set; }
    }
}
