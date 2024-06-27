using App.DTO;

namespace App.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsCalculateRequestValid(CalculateRequest calculateRequest)
        {
            if (calculateRequest.YearOfDeath > calculateRequest.AgeOfDeath)
            {
                return true;
            }
            return false;
        }

        public static bool IsCalculateRequestsValid(List<CalculateRequest> calculateRequests)
        {
            var res = calculateRequests.All(v => IsCalculateRequestValid(v));
            return res;

        }
    }
}
