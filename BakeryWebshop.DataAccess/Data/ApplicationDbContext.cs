using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using BakeryWebshop.Models.Models;

namespace BakeryWebshop.DataAccess.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    // Always use plural here
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    // Seed data here (there are other ways of doing this)
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new
            {
                Id = 1,
                Name = "Bagels",
                DisplayOrder = 1
            },
            new
            {
                Id = 2,
                Name = "Breads",
                DisplayOrder = 2
            },
            new
            {
                Id = 3,
                Name = "Pies",
                DisplayOrder = 3
            },
            new
            {
                Id = 4,
                Name = "Desserts",
                DisplayOrder = 4
            });

        modelBuilder.Entity<Product>().HasData(
            new
            {
                Id = 1,
                Name = "Apple Pie",
                Description = "Pie with apple",
                Mass = 500,
                Calories = 1000,
                Carbs = 350,
                Protein = 40,
                Fats = 15,
                Price = 15.0,
            });
    }
}
