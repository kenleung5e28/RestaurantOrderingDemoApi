using RestaurantOrderingDemoApi.Models;

namespace RestaurantOrderingDemoApi.Services
{
    public class MenuService
    {
        private readonly RestaurantContext _restaurantContext;

        public MenuService(RestaurantContext restaurantContext)
        {
            _restaurantContext = restaurantContext;
        }

        public MenuDto? GetMenu(int menuId)
        {
            return _restaurantContext.Menus
            .Where(menu => menu.MenuId == menuId)
            .Select(menu => new MenuDto
            {
                Name = menu.Name,
                Items = menu.Items.ToList(),
                Combos = menu.Combos.ToList(),
            }).FirstOrDefault();
        }
    }
}
