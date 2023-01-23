using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options) : base (options)
        {
            // Leave blank for now
        }

        public DbSet<AddMovie> addMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddMovie>().HasData(
                new AddMovie
                {
                    Id = 1,
                    Category = "Action/Adventure",
                    Title = "Top Gun",
                    Year = "1986",
                    Director = "Tony Scott",
                    Rating = "PG"
                },
                new AddMovie
                {
                    Id = 2,
                    Category = "Comedy",
                    Title = "The Sandlot",
                    Year = "1993",
                    Director = "David Mickey Evans",
                    Rating = "PG"
                },
                new AddMovie
                {
                    Id = 3,
                    Category = "Television",
                    Title = "The Office",
                    Year = "2005-2013",
                    Director = "Various",
                    Rating = "PG"
                },
                new AddMovie
                {
                    Id = 4,
                    Category = "Comedy",
                    Title = "Grown Ups",
                    Year = "2010",
                    Director = "Dennis Dugan",
                    Rating = "PG-13"
                },
                new AddMovie
                {
                    Id = 5,
                    Category = "Action/Adventure",
                    Title = "Spider-Man",
                    Year = "2002",
                    Director = "Sam Raimi",
                    Rating = "PG-13"
                }
            );
        }
    }
}
