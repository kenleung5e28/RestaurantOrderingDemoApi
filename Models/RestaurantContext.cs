using Microsoft.EntityFrameworkCore;

namespace RestaurantOrderingDemoApi.Models
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {

        }

        public DbSet<Category> Menus { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
