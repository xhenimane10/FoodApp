using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FoodApp.Dto;
using FoodApp.Services;

namespace FoodApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {

        [HttpGet("All")]
        public IActionResult GetFood()
        {
            //List of students
            var allFood = new List<FoodApp.models.Food>()
            {
                  new FoodApp.models.Food()
                  {
                    Gr = 1,
                    Name = "First Food",
                  
                  },
                   new FoodApp.models.Food()
                   {
                    Gr = 2,
                    Name = "Second Food",
           
                   },
            };

            return Ok(allFood);
        }

        [HttpGet]
        public IActionResult GetFoodAppByCal(float cal)
        {
            var newFoodApp = new models.Food()
            {
                Gr = 1,
                Name = "First  FoodApp",
            };

            return Ok();
        }


        [HttpPost]
        public IActionResult AddNewFoodApp([FromBody] PostFoodDto payload)
        {
            return Ok(payload);
        }


        [HttpPut("Name")]
        public IActionResult UpdatFoodApp([FromBody] PutFoodDto payload, string name)
        {
            return Ok(payload);
        }


        [HttpDelete]
        public IActionResult DeleteFoodApp(int gr)
        {
            return Ok();
        }
    }
}
