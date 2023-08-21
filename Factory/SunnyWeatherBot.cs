using WeatherSystem.Models;

namespace WeatherSystem.Factory
{
    public class SunnyWeatherBot : IBotFactory
    {
        public bool Enabled { get; set; }
        public double TempretureThreshold { get; set; }
        public string? Message { get; set; }

        public SunnyWeatherBot()
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