using WeatherSystem.Models;

namespace WeatherSystem.Factory
{
    public class RainWeather : IBotFactory
    {
        public bool Enabled { get; set; }
        public double HumidityThreshold { get; set; }
        public string? Message { get; set; }

        public RainWeather()
        {

        }

        public void DisplayMessage(WeatherDTO weather)
        {
            bool valueExceed = weather.Humidity > HumidityThreshold;
            if (Enabled && valueExceed)
            {
                Console.WriteLine("RainBot is activated!");
                Console.WriteLine(Message);
            }
        }
    }
}