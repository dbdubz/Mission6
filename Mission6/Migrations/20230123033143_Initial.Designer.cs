// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6.Models;

namespace Mission6.Migrations
{
    [DbContext(typeof(MoviesContext))]
    [Migration("20230123033143_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6.Models.AddMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
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

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("addMovies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Action/Adventure",
                            Director = "Tony Scott",
                            Edited = false,
                            Rating = "PG",
                            Title = "Top Gun",
                            Year = "1986"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Comedy",
                            Director = "David Mickey Evans",
                            Edited = false,
                            Rating = "PG",
                            Title = "The Sandlot",
                            Year = "1993"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Television",
                            Director = "Various",
                            Edited = false,
                            Rating = "PG",
                            Title = "The Office",
                            Year = "2005-2013"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Comedy",
                            Director = "Dennis Dugan",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Grown Ups",
                            Year = "2010"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Action/Adventure",
                            Director = "Sam Raimi",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Spider-Man",
                            Year = "2002"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
