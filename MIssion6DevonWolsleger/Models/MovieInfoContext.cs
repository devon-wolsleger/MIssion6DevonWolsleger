using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIssion6DevonWolsleger.Models
{
    public class MovieInfoContext : DbContext
    {
        public MovieInfoContext(DbContextOptions<MovieInfoContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Catagory> Catagories { get; set; }


        //Seed the data 
        protected override void OnModelCreating (ModelBuilder mb)
        {
            mb.Entity<Catagory>().HasData(
                new Catagory { CatagoryId = 1, CatagoryName = "Action" },
                new Catagory { CatagoryId = 2, CatagoryName = "Adventure" },
                new Catagory { CatagoryId = 3, CatagoryName = "Romance" },
                new Catagory { CatagoryId = 4, CatagoryName = "Thriller" },
                new Catagory { CatagoryId = 5, CatagoryName = "Horror" });

            mb.Entity<ApplicationResponse>().HasData(

                    new ApplicationResponse
                    {
                        ApplicationId = 1,
                        CatagoryId = 1,
                        Title = "Kill Bill",
                        Year = 2003,
                        Director = "Quinten Tarentino",
                        Rating = "R",
                        Edited = false,
                        LentTo = null,
                        Notes = null,
                    },
                    new ApplicationResponse
                    {
                        ApplicationId = 2,
                        CatagoryId = 1,
                        Title = "Star Wars Episode I: The Phantom Menace",
                        Year = 1999,
                        Director = "George Lucas",
                        Rating = "PG",
                        Edited = false,
                        LentTo = null,
                        Notes = null,
                    },
                    new ApplicationResponse
                    {
                        ApplicationId = 3,
                        CatagoryId = 2,
                        Title = "Snow White and the Seven Dwarfs",
                        Year = 1938,
                        Director = "Larry Morey",
                        Rating = "G",
                        Edited = false,
                        LentTo = null,
                        Notes = null,
                    }
                );
        }
    }
}
