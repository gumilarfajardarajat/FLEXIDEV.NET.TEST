namespace App.Helpers
{
    public static class CalculateHelper
    {
        public static int GetFibonacci(int number)
        {
            if (number <= 1)
                return number;

            int fibonaci = 1;
            int previousFibonaci = 1;

            for (int i = 2; i < number; i++)
            {
                int temporary = fibonaci;
                fibonaci += previousFibonaci;
                previousFibonaci = temporary;
            }

            return fibonaci;
        }

        public static int GetKilledVillagers(int number)
        {
            List<int> list = new List<int>() { 0 };
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i == 1)
                {
                    result = GetFibonacci(i);
                    list.Add(result);
                }
                else
                {
                    result = list[i - 1] + GetFibonacci(i);
                    list.Add(result);
                }
            }
            return result;
        }

        public static int GetKilledVillagersByAgeYear(int ageOfDeath, int yearOfDath)
        {
            var difference = yearOfDath - ageOfDeath;
            return GetKilledVillagers(difference);
        }

        public static double GetAverage(List<int> values)
        {
            double sum = values.Sum();
            double average = sum / values.Count;
            return average;
        }

    }
}
