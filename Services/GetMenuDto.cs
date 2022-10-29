using RestaurantOrderingDemoApi.Models;

namespace RestaurantOrderingDemoApi.Services
{
    public class GetMenuDto
    {
        public string Name { get; set; } = string.Empty;
        public List<GetMenuItemDto> Items { get; set; } = new List<GetMenuItemDto>();
        public List<GetMenuComboDto> Combos { get; set; } = new List<GetMenuComboDto>();
    }

    public class GetMenuItemDto
    {
        public int ItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }
    
    public class GetMenuComboDto
    {
        public int ComboId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
