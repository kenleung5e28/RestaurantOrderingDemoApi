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
    public string Name { get; set; }
    public ItemType Type { get; set; }
    public Category Category { get; set; }
    public ICollection<Combo> Combos { get; set; }
    public ICollection<Menu> Menus { get; set; }
}