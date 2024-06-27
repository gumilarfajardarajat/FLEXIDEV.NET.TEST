using App.DTO;
using App.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class ValidationHelperTest
    {
        [Fact]
        public void isCalculateRequestValidTest()
        {
            var calculateRequest = new CalculateRequest()
            {
                AgeOfDeath = 10,
                YearOfDeath = 12
            };

            var res = ValidationHelper.IsCalculateRequestValid(calculateRequest);
            Assert.True(res);

        }

        [Fact]
        public void isCalculateRequestsValidTest()
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


            var res = ValidationHelper.IsCalculateRequestsValid(list);
            Assert.True(res);

        }
    }
}
