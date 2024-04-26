using FoodApp.Dto;
using System.Reflection;
namespace FoodApp.Services
{
    public interface IFoodAppService 
    {
        models.Food GetFoodAppByName(string  name);
        models.Food AddFoodApp(PostFoodDto foodapp);
        models.Food UpdateFoodApp(PutFoodDto foodappData, string name);
        void DeleteFoodApp(string name);

    }
}
