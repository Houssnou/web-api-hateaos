using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api_hateoas.Models;

namespace web_api_hateoas.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Poster> Posters { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<Director> Directors { get; set; }

        // seed the database with data for movies directors
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>().HasData(
                new Director()
                {
                    DirectorId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    FirstName = "Quentin",
                    LastName = "Tarantino"
                },
                new Director()
                {
                    DirectorId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    FirstName = "Joel",
                    LastName = "Coen"
                },
                new Director()
                {
                    DirectorId = Guid.Parse("c19099ed-94db-44ba-885b-0ad7205d5e40"),
                    FirstName = "Martin",
                    LastName = "Scorsese"
                },
                new Director()
                {
                    DirectorId = Guid.Parse("0c4dc798-b38b-4a1c-905c-a9e76dbef17b"),
                    FirstName = "David",
                    LastName = "Fincher"
                },
                new Director()
                {
                    DirectorId = Guid.Parse("937b1ba1-7969-4324-9ab5-afb0e4d875e6"),
                    FirstName = "Bryan",
                    LastName = "Singer"
                },
                new Director()
                {
                    DirectorId = Guid.Parse("7a2fbc72-bb33-49de-bd23-c78fceb367fc"),
                    FirstName = "James",
                    LastName = "Cameron"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
