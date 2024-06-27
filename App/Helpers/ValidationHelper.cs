using App.DTO;

namespace App.Helpers
{
    public static class ValidationHelper
    {
        public static void CheckCalculateRequest(CalculateRequest calculateRequest)
        {
            if (calculateRequest.YearOfDath < calculateRequest.AgeOfDeath)
            {
                throw new ArgumentException("-1");
            }
        }
    }
}
