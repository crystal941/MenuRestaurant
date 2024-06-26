using MenuRestaurant.Data;
using MenuRestaurant.Interface;
using MenuRestaurant.Models;

namespace MenuRestaurant.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly DataContext _context;
        public MenuRepository(DataContext context)
        {
            _context = context;
        }
        public Menu DeleteMenuById(Guid Id)
        {
            var menu = _context.Menus.Find(Id);
            _context.Menus.Remove(menu);
            _context.SaveChanges();
            return menu;
        }

        public List<Menu> GetAllMenus()
        {
            var menus = _context.Menus.OrderBy(i => i.Id).ToList();
            return menus;
        }

        public Menu GetMenuById(Guid Id)
        {
            var menu = _context.Menus.Find(Id);
            return menu;
        }

        public Menu PostMenu(Menu menu)
        {
            _context.Menus.Add(menu);
            _context.SaveChanges();
            return menu;
        }

        public Menu UpdateMenuById(Guid Id, Menu menu)
        {
            var menuUpdated = _context.Menus.Find(Id);
            menuUpdated.FoodName = menu.FoodName;
            menuUpdated.FoodType = menu.FoodType;
            menuUpdated.FoodCourse = menu.FoodCourse;
            _context.SaveChanges();
            return menuUpdated;
        }
    }
}
