using App.DTO;
using App.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class CalculateController:ControllerBase
    {
        [HttpPost]
        public IActionResult Index(CalculateRequest calculateRequest)
        {
            try
            {
                ValidationHelper.CheckCalculateRequest(calculateRequest);
                var result = CalculateHelper.GetKilledVillagersByAgeYear(calculateRequest.AgeOfDeath,calculateRequest.YearOfDath);
                return Ok(result);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
            
        }
    }
}
