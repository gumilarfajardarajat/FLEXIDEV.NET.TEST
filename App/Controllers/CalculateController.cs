using App.DTO;
using App.Helpers;
using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class CalculateController:ControllerBase
    {
        private ICalculateService _calculateService;

        public CalculateController(ICalculateService calculateService)
        {
            _calculateService = calculateService;
        }

        [HttpPost]
        [Route("Calculate")]
        public IActionResult Index([FromBody] List<CalculateRequest> calculate)
        {
            try
            {
                var result = _calculateService.CalculateAll(calculate);
                return Ok(result);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("GetAverage")]
        public IActionResult GetAverage([FromBody] List<CalculateRequest> calculate)
        {
            try
            {
                return Ok(calculate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
