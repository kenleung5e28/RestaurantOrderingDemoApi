using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace RestaurantOrderingDemoApi.Models
{
    public class RestaurantContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(
                "Server=127.0.0.1;Port=5432;Database=restaurant_demo;" +
                "User Id=postgres;Password=postgres;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = -1, Name = "Drinks" },
                new Category { CategoryId = -2, Name = "Main course" });
            modelBuilder.Entity<Item>().HasData(
                new { ItemId = -1, Name = "Rice", Type = ItemType.Food, CategoryId = -2 },
                new { ItemId = -2, Name = "Cheese burger", Type = ItemType.Food, CategoryId = -2 },
                new { ItemId = -100, Name = "Iced lemon tea", Type = ItemType.Drink, CategoryId = -1 });
            modelBuilder.Entity<Menu>().HasData(
                new Menu { 
                    MenuId = -1, Name = "A la carte", 
                    AvailableOnHolidays = true, AvailableOnWeekdays = true,
                });
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Menu> Menus { get; set; }
    }
}
