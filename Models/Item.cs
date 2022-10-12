using System.ComponentModel.DataAnnotations;

namespace RestaurantOrderingDemoApi.Models;

public class Item
{
    public int ItemId { get; set; }
    public int MenuId { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
}