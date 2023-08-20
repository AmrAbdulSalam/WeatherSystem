using WeatherSystem.Models;

namespace WeatherSystem.Factory
{
    public class SunnyWeather : IBotFactory
    {
        public bool Enabled { get; set; }
        public double TempretureThreshold { get; set; }
        public string? Message { get; set; }

        public SunnyWeather()
        {
        }

        public void DisplayMessage(WeatherDTO weather)
        {
            bool valueExceed = weather.Temperature > TempretureThreshold;
            if (Enabled && valueExceed)
            {
                Console.WriteLine("SunBot is activated!");
                Console.WriteLine(Message);
            }
        }
    }
}