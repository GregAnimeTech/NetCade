using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCade.Models;
using Microsoft.EntityFrameworkCore;

namespace NetCade.Data
{
    public class NetCadeContext : DbContext
    {
        public DbSet<UserAccount> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=Bakery.db");
        }
    }
}
