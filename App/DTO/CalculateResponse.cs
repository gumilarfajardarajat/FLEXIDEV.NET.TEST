namespace App.DTO
{
    public class CalculateResponse
    {
        public List<CalculateDetailResponse> Details {  get; set; } 
        public double Average { get; set; }
    }

    public class CalculateDetailResponse
    {
        public int Difference { get; set; }
        public int Killed { get; set;}
    }
}
