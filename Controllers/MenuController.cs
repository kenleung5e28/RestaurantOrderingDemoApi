using Microsoft.AspNetCore.Mvc;
using RestaurantOrderingDemoApi.Models;
using RestaurantOrderingDemoApi.Services;

namespace RestaurantOrderingDemoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MenuController : ControllerBase
{
    private readonly ILogger<MenuController> _logger;
    private readonly RestaurantContext _context;

    public MenuController(RestaurantContext context, ILogger<MenuController> logger)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public MenuDto? Get(int menuId)
    {
        var menuService = new MenuService(_context);
        return menuService.GetMenu(menuId);
    }
}