using Microsoft.EntityFrameworkCore;

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

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Menu> Menus { get; set; }
    }
}
