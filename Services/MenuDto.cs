using RestaurantOrderingDemoApi.Models;

namespace RestaurantOrderingDemoApi.Services
{
    public class MenuDto
    {
        public string Name { get; set; } = String.Empty;
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Combo> Combos { get; set; } = new List<Combo>();
    }
}
