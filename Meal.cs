namespace CarbonTrackerMVC.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Food { get; set; } = string.Empty;
        public double Quantity { get; set; }     // grams
        public double Emission { get; set; }
        public DateTime Date { get; set; }       // meal date
    }
}
