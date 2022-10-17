using Microsoft.AspNetCore.Mvc;
using RestaurantOrderingDemoApi.Models;

namespace RestaurantOrderingDemoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MenuController : ControllerBase
{
    private readonly ILogger<MenuController> _logger;

    public MenuController(ILogger<MenuController> logger)
    {
        _logger = logger;
    }

    public record MenuDto
    {
        public string Name { get; set; }
        public List<Item>? Items { get; set; }
        public List<Combo>? Combos { get; set; }
    }

    [HttpGet]
    public MenuDto? Get(int menuId)
    {
        using var context = new RestaurantContext();
        return context.Menus
            .Where(menu => menu.MenuId == menuId)
            .Select(menu => new MenuDto
            {
                Name = menu.Name,
                Items = menu.Items.ToList(),
                Combos = menu.Combos.ToList(),
            }).FirstOrDefault();
    }
}