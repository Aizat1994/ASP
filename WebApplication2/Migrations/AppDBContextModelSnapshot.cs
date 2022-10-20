﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Models;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApplication2.Models.Home", b =>
                {
                    b.Property<Guid>("HomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HomeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsNeighbour")
                        .HasColumnType("bit");

                    b.HasKey("HomeId");

                    b.ToTable("home");
                });

            modelBuilder.Entity("WebApplication2.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HomeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkinCollor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("WebApplication2.Models.User", b =>
                {
                    b.HasOne("WebApplication2.Models.Home", "Home")
                        .WithMany()
                        .HasForeignKey("HomeId");

                    b.Navigation("Home");
                });
#pragma warning restore 612, 618
        }
    }
}