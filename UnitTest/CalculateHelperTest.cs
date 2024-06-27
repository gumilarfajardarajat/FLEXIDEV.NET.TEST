using App.Helpers;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit.Abstractions;

namespace UnitTest
{
    public class CalculateHelperTest
    {
        public static ITestOutputHelper output;

        public CalculateHelperTest(ITestOutputHelper testOutputHelper)
        {
            output = testOutputHelper;
        }

        [Fact]
        public void GetFibonaciTest()
        {
            Assert.Equal(0, CalculateHelper.GetFibonacci(0));
            Assert.Equal(1, CalculateHelper.GetFibonacci(1));
            Assert.Equal(1, CalculateHelper.GetFibonacci(2));
            Assert.Equal(2, CalculateHelper.GetFibonacci(3));
            Assert.Equal(3, CalculateHelper.GetFibonacci(4));
            Assert.Equal(5, CalculateHelper.GetFibonacci(5));
        }


        [Fact]
        public void GetKilledVillagersTest()
        {
            Assert.Equal(0, CalculateHelper.GetKilledVillagers(0));
            Assert.Equal(1, CalculateHelper.GetKilledVillagers(1));
            Assert.Equal(2, CalculateHelper.GetKilledVillagers(2));
            Assert.Equal(4, CalculateHelper.GetKilledVillagers(3));
            Assert.Equal(7, CalculateHelper.GetKilledVillagers(4));
            Assert.Equal(12, CalculateHelper.GetKilledVillagers(5));
        }

        [Fact]
        public void GetKilledVillagersByAgeYearTest()
        {
            Assert.Equal(2, CalculateHelper.GetKilledVillagersByAgeYear(10, 12));
            Assert.Equal(7, CalculateHelper.GetKilledVillagersByAgeYear(13, 17));
        }


        [Fact]
        public void GetAverageTest()
        {
            // Arrange
            List<int> values = new List<int>();
            values.Add(CalculateHelper.GetKilledVillagersByAgeYear(10, 12));
            values.Add(CalculateHelper.GetKilledVillagersByAgeYear(13, 17));

            // Act
            double average = CalculateHelper.GetAverage(values);

            // Assert
            Assert.Equal(4.5, average); // Expected average is 3.0

        }

        [Fact]
        public void Main()
        {
            // Arrange
            List<int> values = new List<int>();
            values.Add(1);
            values.Add(2);

            var res = values.All(v => v > 0);
            Assert.True(res);


        }
    }
}