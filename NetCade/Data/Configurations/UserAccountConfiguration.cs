using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCade.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NetCade.Data.Configurations
{
    public class UserAccountConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.Property(p => p.UserName).HasColumnName("UserAccountName");
        }
    }
}
