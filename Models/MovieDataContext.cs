using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Models
{
    public class MovieDataContext : DbContext
    { 
        //Constructor
        public MovieDataContext (DbContextOptions<MovieDataContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }


        // Seeding the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                    new ApplicationResponse
                    {
                        ApplicationId = 1,
                        Title = "Twilight: Breaking Dawn Part 1",
                        Year = "2011",
                        Director = "Bill Condon",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = ""
                    },
                    new ApplicationResponse
                    {
                        ApplicationId = 2,
                        Title = "Twilight: Breaking Dawn Part 2",
                        Year = "2012",
                        Director = "Bill Condon",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = ""
                    },
                    new ApplicationResponse
                    {
                        ApplicationId = 3,
                        Title = "Megamind",
                        Year = "2010",
                        Director = "Tom McGrath",
                        Rating = "PG",
                        Edited = false,
                        LentTo = "",
                        Notes = ""
                    }
               );
        }
    }
}
