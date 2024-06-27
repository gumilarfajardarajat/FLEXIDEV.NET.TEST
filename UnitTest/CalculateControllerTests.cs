using App.Controllers;
using App.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class CalculateControllerTests
    {
        private CalculateController calculateController;

        public CalculateControllerTests()
        {
            calculateController = new CalculateController();
        }

        [Fact]
        public void IndexTestResultOk()
        {
            var calculateRequest = new CalculateRequest()
            {
                AgeOfDeath = 10,
                YearOfDath = 12
            };

            var response = calculateController.Index(calculateRequest);
            var result = response as OkObjectResult;
            Assert.IsAssignableFrom<OkObjectResult>(result);
            Assert.Equal(2, result.Value);
        }

        [Fact]
        public void IndexTestResultBad()
        {
            var calculateRequest = new CalculateRequest()
            {
                AgeOfDeath = 12,
                YearOfDath = 10
            };

            var response = calculateController.Index(calculateRequest);
            var result = response as BadRequestObjectResult;
            Assert.IsAssignableFrom<BadRequestObjectResult>(result);
            Assert.Equal("-1", result.Value);
        }
    }

}
