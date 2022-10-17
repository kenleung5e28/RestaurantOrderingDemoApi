using System.ComponentModel.DataAnnotations;

namespace RestaurantOrderingDemoApi.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = String.Empty;
        public bool AvailableOnWeekdays { get; set; }
        public bool AvailableOnHolidays { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item>();
        public ICollection<Combo> Combos { get; set; } = new List<Combo>();
    }
}
