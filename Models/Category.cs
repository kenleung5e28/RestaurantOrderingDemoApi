using System.ComponentModel.DataAnnotations;

namespace RestaurantOrderingDemoApi.Models;

public class Category
{
    public int CategoryId { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = String.Empty;
    public ICollection<Item> Items { get; set; } = new List<Item>();
}