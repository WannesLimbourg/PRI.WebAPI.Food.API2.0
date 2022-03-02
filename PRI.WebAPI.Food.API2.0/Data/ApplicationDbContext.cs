using Microsoft.EntityFrameworkCore;
using PRI.WebAPI.Food.API2._0.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRI.WebAPI.Food.API2._0.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                 new[]
               {
                    new Category
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Name = "Pizza",
                        CreatedOn = DateTime.UtcNow,
                        LastEditedOn = DateTime.UtcNow
                    }, new Category
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        Name = "Pasta",
                        CreatedOn = DateTime.UtcNow,
                        LastEditedOn = DateTime.UtcNow
                    }, new Category
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                        Name = "Groenten",
                        CreatedOn = DateTime.UtcNow,
                        LastEditedOn = DateTime.UtcNow
                    }, new Category
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                        Name = "Fruit",
                        CreatedOn = DateTime.UtcNow,
                        LastEditedOn = DateTime.UtcNow
                    }
               }
                );

            modelBuilder.Entity<Product>().HasData(
                new[]
               {
                    new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Name = "Peperoni",
                        CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000001"), // Pizza
                        CreatedOn = DateTime.UtcNow,
                        LastEditedOn = DateTime.UtcNow
                    }, new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        Name = "Hawai",
                        CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000001"), // Pizza
                        CreatedOn = DateTime.UtcNow,
                        LastEditedOn = DateTime.UtcNow
                    }, new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                        Name = "Macaroni",
                        CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000002"), // Pasta
                        CreatedOn = DateTime.UtcNow,
                        LastEditedOn = DateTime.UtcNow
                    }, new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                        Name = "Spaghetti",
                        CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000002"), // Pasta
                        CreatedOn = DateTime.UtcNow,
                        LastEditedOn = DateTime.UtcNow
                    }, new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                        Name = "Komkommer",
                        CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), // Groenten
                        CreatedOn = DateTime.UtcNow,
                        LastEditedOn = DateTime.UtcNow
                    }, new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                        Name = "Tomaat",
                        CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000003"), // Groenten
                        CreatedOn = DateTime.UtcNow,
                        LastEditedOn = DateTime.UtcNow
                    }, new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                        Name = "Appel",
                        CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), // Fruit
                        CreatedOn = DateTime.UtcNow,
                        LastEditedOn = DateTime.UtcNow
                    }, new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                        Name = "Peer",
                        CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000004"), // Fruit
                        CreatedOn = DateTime.UtcNow,
                        LastEditedOn = DateTime.UtcNow
                    }
               }
                );
        }
    }
}
