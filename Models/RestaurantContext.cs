using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace RestaurantOrderingDemoApi.Models
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {}
        
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
                new Menu
                {
                    MenuId = -1,
                    Name = "A la carte",
                    AvailableOnHolidays = true,
                    AvailableOnWeekdays = true,
                });
            modelBuilder.Entity<Menu>()
                .HasMany(menu => menu.Items)
                .WithMany(item => item.Menus)
                .UsingEntity(j => j.ToTable("ItemMenu").HasData(
                    new { MenusMenuId = -1, ItemsItemId = -1 },
                    new { MenusMenuId = -1, ItemsItemId = -2 }));
        }

        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Item> Items => Set<Item>();
        public DbSet<Combo> Combos => Set<Combo>();
        public DbSet<Menu> Menus => Set<Menu>();
    }
}
