using App.DTO;
using App.Helpers;

namespace App.Services
{
    public class CalculateService : ICalculateService
    {
        public CalculateResponse CalculateAll(List<CalculateRequest> calculateRequests)
        {
            var isCalculateRequestsValid = ValidationHelper.IsCalculateRequestsValid(calculateRequests);
            if(!isCalculateRequestsValid)
            {
                throw new Exception("-1");
            }
            CalculateResponse response = new CalculateResponse();
            var calculateDetailResponse = calculateRequests.Select(value => new CalculateDetailResponse()
            {
                Killed = CalculateHelper.GetKilledVillagersByAgeYear(value.AgeOfDeath, value.YearOfDeath),
                Difference = value.YearOfDeath - value.AgeOfDeath,
            }).ToList();

            var listKilled = calculateDetailResponse.Select(value => value.Killed).ToList();
            var average = CalculateHelper.GetAverage(listKilled);
            response.Details = calculateDetailResponse.ToList();
            response.Average = average;
            return response;
        }
    }
}
