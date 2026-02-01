namespace CarbonTrackerMVC.Services
{
    public static class EmissionData
    {
        public static Dictionary<string, double> FoodEmissions = new()
        {
            // 🌱 Vegetarian
            { "Dal", 1.8 },
            { "Rice", 4.0 },
            { "Roti", 1.2 },
            { "Paneer", 7.5 },
            { "Rajma", 2.0 },
            { "Vegetable Sabzi", 2.0 },
            { "Chole", 2.1 },
            { "Curd", 2.2 },
            { "Milk", 3.2 },
            { "Vegetable Pulao", 2.8 },
            { "Idli", 1.4 },

            // 🍗 Non-Vegetarian
            { "Chicken Curry", 6.9 },
            { "Chicken Biryani", 7.2 },
            { "Egg Curry", 4.8 },
            { "Fish Curry", 5.4 },
            { "Mutton Curry", 20.0 }
        };
    }
}
