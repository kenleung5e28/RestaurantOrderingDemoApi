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

        public GetMenuDto? GetMenu(int menuId)
        {
            return _restaurantContext.Menus
            .Where(menu => menu.MenuId == menuId)
            .Select(menu => new GetMenuDto
            {
                Name = menu.Name,
                Items = menu.Items.Select(item => new GetMenuItemDto
                {
                    ItemId = item.ItemId,
                    Name = item.Name,
                    Type = item.Type.ToString(),
                    ActualPrice = item.Price
                }).ToList(),
                Combos = menu.Combos.Select(combo => new GetMenuComboDto
                {
                    ComboId = combo.ComboId,
                    Name = combo.Name,
                    ActualPrice = combo.Price
                }).ToList()
            }).FirstOrDefault();
        }
    }
}
