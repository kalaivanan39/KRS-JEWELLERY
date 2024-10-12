﻿// <auto-generated />
using KRSJewellery.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KRSJewellery.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    partial class MyAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KRSJewellery.Models.Employees", b =>
                {
                    b.Property<int>("EMPID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EMPID"));

                    b.Property<string>("CONTACT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMPNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLACE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SALARY")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EMPID");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
