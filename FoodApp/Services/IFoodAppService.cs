using FoodApp.Dto;
using System.Reflection;
namespace FoodApp.Services
{
    public interface IFoodAppService
    {
        List<models.Food> GetAllFood();
        models.Food GetFoodAppByName(string name);
        models.Food AddFoodApp(PostFoodDto foodapp);
        models.Food UpdateFoodApp(PutFoodDto foodappData, string name);
        void DeleteFoodApp(int gr);

    }
}
