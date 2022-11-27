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
    [Migration("20221127172203_director")]
    partial class director
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FilmApp.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FilmApp.Entities.Director", b =>
                {
                    b.Property<int>("DirectorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DirectorID"), 1L, 1);

                    b.Property<string>("DirectorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DirectorID");

                    b.ToTable("Director");
                });

            modelBuilder.Entity("FilmApp.Entities.FilmFeatures", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("DirectorID")
                        .HasColumnType("int");

                    b.Property<string>("FilmComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("watched")
                        .HasColumnType("bit");

                    b.HasKey("FilmId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DirectorID");

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

            modelBuilder.Entity("FilmApp.Entities.FilmFeatures", b =>
                {
                    b.HasOne("FilmApp.Entities.Category", "Category")
                        .WithMany("filmFeatures")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmApp.Entities.Director", "Director")
                        .WithMany("filmFeatures")
                        .HasForeignKey("DirectorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Director");
                });

            modelBuilder.Entity("FilmApp.Entities.Category", b =>
                {
                    b.Navigation("filmFeatures");
                });

            modelBuilder.Entity("FilmApp.Entities.Director", b =>
                {
                    b.Navigation("filmFeatures");
                });
#pragma warning restore 612, 618
        }
    }
}
