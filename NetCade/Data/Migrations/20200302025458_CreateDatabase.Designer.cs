﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCade.Data;

namespace NetCade.Data.Migrations
{
    [DbContext(typeof(NetCadeContext))]
    [Migration("20200302025458_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("NetCade.Models.UserAccount", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnName("UserAccountName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("UserName");

                    b.ToTable("UserAccounts");

                    b.HasData(
                        new
                        {
                            UserName = "FuckMeInAss",
                            Name = "Greg",
                            Password = "1234"
                        },
                        new
                        {
                            UserName = "Mini-carrot cake",
                            Name = "Carrot Cake",
                            Password = "899"
                        },
                        new
                        {
                            UserName = "ThatAss",
                            Name = "Cake",
                            Password = "L0L"
                        },
                        new
                        {
                            UserName = "AssIsBest",
                            Name = "Bob",
                            Password = "911"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}