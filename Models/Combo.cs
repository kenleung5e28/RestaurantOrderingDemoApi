using System.ComponentModel.DataAnnotations;

namespace RestaurantOrderingDemoApi.Models
{
    public class Combo
    {
        public int ComboId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public ICollection<Item> Items { get; set; } = new List<Item>();
        public ICollection<Menu> Menus { get; set; } = new List<Menu>();
    }
}
