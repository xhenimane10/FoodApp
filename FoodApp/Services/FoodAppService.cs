using FoodApp.Dto;
namespace FoodApp.Services
{
    public class FoodAppService : IFoodAppService
    {
        private AppDbContext _context;
        public FoodAppService(AppDbContext context)
        {
            _context = context;
        }
        public List<models.Food> GetAllFood()
        {
            var allFood = _context.FoodApp.ToList();
            return allFood;
        }
        public models.Food AddFoodApp(PostFoodDto food)
        {
            var newFood = new models.Food()
            {
                Name = food.Name,
                Gr = food.Gr,
                Cal = food.Cal,
                Example = food.Example
            };
            _context.FoodApp.Add(newFood);
            _context.SaveChanges();

            return newFood;
        }
        public void DeleteFoodApp(int gr)
        {
            var foodDb = _context.FoodApp
                .FirstOrDefault(n => n.Gr == gr);

            _context.FoodApp.Remove(foodDb);
            _context.SaveChanges();
        }
        public models.Food GetFoodAppByName(string name)
        {
            var newFood = _context.FoodApp
                .FirstOrDefault(n => n.Name == name);

            return newFood;
        }
        public models.Food UpdateFoodApp(PutFoodDto foodData, string name)
        {
            var foodDb = _context.FoodApp
                .FirstOrDefault(n => n.Name == name);

            foodDb.Name = foodData.Name;
            _context.FoodApp.Update(foodDb);

            _context.SaveChanges();

            return foodDb;
        }
    }
}
    
