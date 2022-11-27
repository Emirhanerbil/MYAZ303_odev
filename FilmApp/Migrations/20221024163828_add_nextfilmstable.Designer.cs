﻿// <auto-generated />
using FilmApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilmApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221024163828_add_nextfilmstable")]
    partial class add_nextfilmstable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FilmApp.Entities.FilmFeatures", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"), 1L, 1);

                    b.Property<string>("FilmComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("watched")
                        .HasColumnType("bit");

                    b.HasKey("FilmId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("FilmApp.Entities.NextFilmFeatures", b =>
                {
                    b.Property<int>("NextFilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NextFilmId"), 1L, 1);

                    b.Property<string>("NextFilmName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("watched")
                        .HasColumnType("bit");

                    b.HasKey("NextFilmId");

                    b.ToTable("NextFilmFeatures");
                });
#pragma warning restore 612, 618
        }
    }
}
