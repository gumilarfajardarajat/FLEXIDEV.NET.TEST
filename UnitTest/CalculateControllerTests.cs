using App.Controllers;
using App.DTO;
using App.Services;
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
        private CalculateService calculateService;
        public CalculateControllerTests()
        {
            calculateService = new CalculateService();
            calculateController = new CalculateController(calculateService);
            
        }

        [Fact]
        public void IndexTestOkBadResult()
        {
            var calculateRequests = new List<CalculateRequest>()
            {
                new CalculateRequest()
                    {
                        AgeOfDeath = 10,
                        YearOfDeath = 12
                    },
                new CalculateRequest()
                    {
                        AgeOfDeath = 13,
                        YearOfDeath = 17
                    }
            };

            var response = calculateController.Index(calculateRequests);
            var result = response as OkObjectResult;
            Assert.IsAssignableFrom<OkObjectResult>(result);
            
        }

        [Fact]
        public void IndexTestBadResult()
        {
            var calculateRequests = new List<CalculateRequest>()
            {
                new CalculateRequest()
                    {
                        AgeOfDeath = 12,
                        YearOfDeath = 1
                    },
                new CalculateRequest()
                    {
                        AgeOfDeath = 13,
                        YearOfDeath = 17
                    }
            };

            var response = calculateController.Index(calculateRequests);
            var result = response as BadRequestObjectResult;
            Assert.IsAssignableFrom<BadRequestObjectResult>(result);

        }


    }

}
