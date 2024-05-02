using FoodApp.models;
using System.Reflection;
namespace FoodApp.Services
{
    public class SqlFoodAppService : IFoodAppService
    {
        public models.Food AddFoodApp(PostFoodDto foodapp)
        {
            throw new NotImplementedException();
        }
        public void DeleteFoodApp(int gr)
        {
            throw new NotImplementedException();
        }

        public List<Food> GetAllFood()
        {
            throw new NotImplementedException();
        }

        public List<models.Food> GetAllFoodApp()
        {
            throw new NotImplementedException();
        }

        public models.Food GetFoodAppByName(string name)
        {
            throw new NotImplementedException();
        }

        public models.Food UpdateFoodApp(PutFoodDto fooddata, string name)
        {
            throw new NotImplementedException();
        }

    }
}
