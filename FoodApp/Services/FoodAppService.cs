using FoodApp.Dto;
using System;
namespace FoodApp.Services
{
    public class FoodAppService : IFoodAppService
    {
        private AppDbContext _context;
        public FoodAppService(AppDbContext context)
        {
            _context = context;
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
        public void DeleteFoodApp(string name)
        {
            var foodDb = _context.FoodApp
                .FirstOrDefault(n => n.Name == name);

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
    
