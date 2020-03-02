using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCade.Models;
using Microsoft.EntityFrameworkCore;
using NetCade.Data.Configurations;

namespace NetCade.Data
{
    public class NetCadeContext : DbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=Bakery.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserAccountConfiguration()).Seed();
        }
    }
}
