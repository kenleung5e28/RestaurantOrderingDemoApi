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

    [HttpGet(Name = "GetMenu")]
    public Menu Get(int menuId)
    {
        return new Menu { MenuId = menuId, Name = "dummy", Items = new List<Item>()};
    }
}