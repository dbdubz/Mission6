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
        public DbSet<MovieCategories> movieCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCategories>().HasData(
                new MovieCategories
                {
                    Id = 1,
                    Name = "Action/Adventure"
                },
                new MovieCategories
                {
                    Id = 2,
                    Name = "Comedy"
                },
                new MovieCategories
                {
                    Id = 3,
                    Name = "Drama"
                },
                new MovieCategories
                {
                    Id = 4,
                    Name = "Family"
                },
                new MovieCategories
                {
                    Id = 5,
                    Name = "Horror/Suspense"
                },
                new MovieCategories
                {
                    Id = 6,
                    Name = "Miscellaneous"
                },
                new MovieCategories
                {
                    Id = 7,
                    Name = "Television"
                },
                new MovieCategories
                {
                    Id = 8,
                    Name = "VHS"
                }
            ) ;
            modelBuilder.Entity<AddMovie>().HasData(
                new AddMovie
                {
                    Id = 1,
                    CategoryID = 1,
                    Title = "Top Gun",
                    Year = "1986",
                    Director = "Tony Scott",
                    Rating = "PG"
                },
                new AddMovie
                {
                    Id = 2,
                    CategoryID = 2,
                    Title = "The Sandlot",
                    Year = "1993",
                    Director = "David Mickey Evans",
                    Rating = "PG"
                },
                new AddMovie
                {
                    Id = 3,
                    CategoryID = 7,
                    Title = "The Office",
                    Year = "2005-2013",
                    Director = "Various",
                    Rating = "PG"
                },
                new AddMovie
                {
                    Id = 4,
                    CategoryID = 2,
                    Title = "Grown Ups",
                    Year = "2010",
                    Director = "Dennis Dugan",
                    Rating = "PG-13"
                },
                new AddMovie
                {
                    Id = 5,
                    CategoryID = 1,
                    Title = "Spider-Man",
                    Year = "2002",
                    Director = "Sam Raimi",
                    Rating = "PG-13"
                }
            );
        }
    }
}
