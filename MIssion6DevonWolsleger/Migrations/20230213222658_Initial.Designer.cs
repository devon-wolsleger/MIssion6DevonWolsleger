﻿// <auto-generated />
using MIssion6DevonWolsleger.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MIssion6DevonWolsleger.Migrations
{
    [DbContext(typeof(MovieInfoContext))]
    [Migration("20230213222658_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("MIssion6DevonWolsleger.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Catagory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            Catagory = "Action",
                            Director = "Quinten Tarentino",
                            Edited = false,
                            Rating = "R",
                            Title = "Kill Bill",
                            Year = 2003
                        },
                        new
                        {
                            ApplicationId = 2,
                            Catagory = "Action",
                            Director = "George Lucas",
                            Edited = false,
                            Rating = "PG",
                            Title = "Star Wars Episode I: The Phantom Menace",
                            Year = 1999
                        },
                        new
                        {
                            ApplicationId = 3,
                            Catagory = "Action",
                            Director = "Larry Morey",
                            Edited = false,
                            Rating = "G",
                            Title = "Snow White and the Seven Dwarfs",
                            Year = 1938
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
