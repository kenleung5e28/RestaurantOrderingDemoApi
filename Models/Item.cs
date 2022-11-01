using System.ComponentModel.DataAnnotations;

namespace RestaurantOrderingDemoApi.Models;

public enum ItemType
{
    Food,
    Drink,
}

public class Item
{
    public int ItemId { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    public ItemType Type { get; set; }
    public Category Category { get; set; }
    public decimal Price { get; set; }
    public ICollection<Combo> Combos { get; set; } = new List<Combo>();
    public ICollection<Menu> Menus { get; set; } = new List<Menu>();
}