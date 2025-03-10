using PizzaStore.Models;
using Microsoft.EntityFrameworkCore;

namespace PizzaStore.Data;

public class PizzaDb : DbContext
{
    public PizzaDb(DbContextOptions options) : base(options) { }
    public DbSet<Pizza> Pizzas { get; set; } = null!;

    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pizza>().HasData(
            new Pizza { Id = 1, Name = "Pepperoni", Description = "Classic Pepperoni Pizza" },
            new Pizza { Id = 2, Name = "Margherita", Description = "Traditional Margherita Pizza" },
            new Pizza { Id = 3, Name = "BBQ Chicken", Description = "BBQ Chicken Pizza with onions and cilantro" },
            new Pizza { Id = 4, Name = "Hawaiian", Description = "Pizza with ham and pineapple" },
            new Pizza { Id = 5, Name = "Veggie", Description = "Vegetarian Pizza with bell peppers, olives, and mushrooms" }
    );
    }
}

// dotnet ef migrations add AddPizzaData
// dotnet ef database update
// dotnet run