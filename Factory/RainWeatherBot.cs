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

        public bool DisplayMessage(WeatherDTO weather)
        {
            bool valueExceed = weather.Humidity > HumidityThreshold;
            if (Enabled && valueExceed)
            {
                Console.WriteLine(Message);
                return true;
            }
            return false;
        }
    }
}