using App.DTO;

namespace App.Services
{
    public interface ICalculateService
    {
        public CalculateResponse CalculateAll(List<CalculateRequest> calculateRequests);
    }
}
