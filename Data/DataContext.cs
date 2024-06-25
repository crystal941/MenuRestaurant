using Microsoft.EntityFrameworkCore;
using MenuRestaurant.Models;

namespace MenuRestaurant.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Menu> Menus { get; set; }
    }
}
