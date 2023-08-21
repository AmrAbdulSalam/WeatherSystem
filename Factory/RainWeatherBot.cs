using WeatherSystem.Models;

namespace WeatherSystem.Factory
{
    public class RainWeatherBot : IBotFactory
    {
        public bool Enabled { get; set; }
        public double HumidityThreshold { get; set; }
        public string? Message { get; set; }

        public RainWeatherBot()
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