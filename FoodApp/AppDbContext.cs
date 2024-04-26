using Microsoft.EntityFrameworkCore;
namespace FoodApp
{ 
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<models.Food> FoodApp { get; set; }
    }
}
