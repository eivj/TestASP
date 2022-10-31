using System;
using TestASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TestASP.AuthCatApp;
using System.Runtime.ConstrainedExecution;

namespace TestASP.Context
{
    public class CatContext : IdentityDbContext<User>
    {   
        public DbSet<Cat> cats { get; set; }
        public CatContext(DbContextOptions options) : base(options) { }


    }
}
