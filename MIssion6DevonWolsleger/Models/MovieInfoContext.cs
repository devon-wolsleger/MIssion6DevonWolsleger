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

        protected override void OnModelCreating (ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                    new ApplicationResponse
                    {
                        ApplicationId = 1,
                        Catagory = "Action",
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
                        Catagory = "Action",
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
                        Catagory = "Action",
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
