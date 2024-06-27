using App.DTO;
using App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class CalculateServiceTest
    {
        private CalculateService calculateService;

        public CalculateServiceTest()
        {
            calculateService = new CalculateService();
        }

        [Fact]
        public void CalculateAllTest()
        {
            var list = new List<CalculateRequest>()
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

            var result = calculateService.CalculateAll(list);
            Assert.Equal(4.5,result.Average);
            Assert.Equal(2, result.Details[0].Difference);
            Assert.Equal(4, result.Details[1].Difference);
            Assert.Equal(2, result.Details[0].Killed);
            Assert.Equal(7, result.Details[1].Killed);


        }
    }
}
