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
    [HttpPut("Name")]
    public IActionResult GetNameByName(string name)
    {
        return Ok();
    }

    [HttpPost("Calories")]
    public IActionResult GetCalByCal(float cal)
    {
        return Ok();
    }
    [HttpOptions("Gram")]
    public IActionResult GetGrbyGr(int gr)
    {
        return Ok();
    }
    [HttpDelete("Name")]
    public IActionResult GetNamebyName(string name)
    {
        return Ok();
    }
}
}