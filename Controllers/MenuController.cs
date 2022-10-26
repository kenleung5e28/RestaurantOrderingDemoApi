using Microsoft.AspNetCore.Mvc;
using RestaurantOrderingDemoApi.Services;

namespace RestaurantOrderingDemoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MenuController : ControllerBase
{
    private readonly ILogger<MenuController> _logger;
    private readonly MenuService _menuService;

    public MenuController(MenuService menuService, ILogger<MenuController> logger)
    {
        _logger = logger;
        _menuService = menuService;
    }

    [HttpGet]
    public MenuDto? Get(int menuId)
    {
        return _menuService.GetMenu(menuId);
    }
}