﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Orai;

#nullable disable

namespace Orai.Migrations
{
    [DbContext(typeof(FociDbContext))]
    partial class FociDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Orai.Meccs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fordulo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HazaiCsapat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HazaiFelidogol")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HazaiGol")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VendegCsapat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VendegFelidogol")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VendegGol")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Meccsek");
                });
#pragma warning restore 612, 618
        }
    }
}
