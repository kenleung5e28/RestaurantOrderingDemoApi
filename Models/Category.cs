using System.ComponentModel.DataAnnotations;

namespace RestaurantOrderingDemoApi.Models;

public class Category
{
    public int CategoryId { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    public ICollection<Item> Items { get; set; }
}