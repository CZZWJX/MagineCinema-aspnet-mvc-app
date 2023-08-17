﻿// <auto-generated />
using System;
using MagineCinema.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MagineCinema.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20230816062814_ModifyMovieProperty")]
    partial class ModifyMovieProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MagineCinema.Models.Actor", b =>
                {
                    b.Property<int>("actorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profilePictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("actorId");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("MagineCinema.Models.Actor_Movie", b =>
                {
                    b.Property<int>("actorId")
                        .HasColumnType("int");

                    b.Property<int>("movieId")
                        .HasColumnType("int");

                    b.HasKey("actorId", "movieId");

                    b.HasIndex("movieId");

                    b.ToTable("Actor_Movie");
                });

            modelBuilder.Entity("MagineCinema.Models.Director", b =>
                {
                    b.Property<int>("directorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profilePictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("directorId");

                    b.ToTable("Director");
                });

            modelBuilder.Entity("MagineCinema.Models.Director_Movie", b =>
                {
                    b.Property<int>("directorId")
                        .HasColumnType("int");

                    b.Property<int>("movieId")
                        .HasColumnType("int");

                    b.HasKey("directorId", "movieId");

                    b.HasIndex("movieId");

                    b.ToTable("Director_Movie");
                });

            modelBuilder.Entity("MagineCinema.Models.Movie", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MovieCategories")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("imageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("language")
                        .HasColumnType("int");

                    b.Property<int>("movieLength")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int>("rate")
                        .HasColumnType("int");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("synopsis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("movieId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MagineCinema.Models.Actor_Movie", b =>
                {
                    b.HasOne("MagineCinema.Models.Actor", "actor")
                        .WithMany("actors_Movies")
                        .HasForeignKey("actorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MagineCinema.Models.Movie", "movie")
                        .WithMany("actors_Movies")
                        .HasForeignKey("movieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("actor");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("MagineCinema.Models.Director_Movie", b =>
                {
                    b.HasOne("MagineCinema.Models.Director", "director")
                        .WithMany("directors_Movies")
                        .HasForeignKey("directorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MagineCinema.Models.Movie", "movie")
                        .WithMany("directors_Movies")
                        .HasForeignKey("movieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("director");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("MagineCinema.Models.Actor", b =>
                {
                    b.Navigation("actors_Movies");
                });

            modelBuilder.Entity("MagineCinema.Models.Director", b =>
                {
                    b.Navigation("directors_Movies");
                });

            modelBuilder.Entity("MagineCinema.Models.Movie", b =>
                {
                    b.Navigation("actors_Movies");

                    b.Navigation("directors_Movies");
                });
#pragma warning restore 612, 618
        }
    }
}