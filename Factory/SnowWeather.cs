using WeatherSystem.Models;

namespace WeatherSystem.Factory
{
    public class SnowWeather : IBotFactory
    {
        public bool Enabled { get; set; }
        public double TempretureThreshold { get; set; }
        public string? Message { get; set; }

        public SnowWeather()
        {
        }

        public void DisplayMessage(WeatherDTO weather)
        {
            bool valueExceed = weather.Temperature < TempretureThreshold;
            if (Enabled && valueExceed)
            {
                Console.WriteLine("SnowBot is activated!");
                Console.WriteLine(Message);
            }

        }
    }
}