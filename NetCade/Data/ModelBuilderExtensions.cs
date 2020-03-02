using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCade.Models;
using Microsoft.EntityFrameworkCore;

namespace NetCade.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>().HasData(
                new UserAccount
                {
                    Name = "Greg",
                    UserName = "FuckMeInAss",
                    Password = "1234",
                },
                new UserAccount
                {
                    Name = "Carrot Cake",
                    UserName = "Mini-carrot cake",
                    Password = "899",
                },
                new UserAccount
                {
                    Name = "Cake",
                    UserName = "ThatAss",
                    Password = "L0L",
                }
            );
            return modelBuilder;
        }
    }
}
