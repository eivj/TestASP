using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestASP.AuthCatApp;
using TestASP.Models;

namespace TestASP.Context
{
    public class CatContext : IdentityDbContext<User>
    {   
        public DbSet<Cat> cats { get; set; }
        public CatContext(DbContextOptions options) : base(options) { }

    }
}
