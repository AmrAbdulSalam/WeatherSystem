using WeatherSystem.Models;

namespace WeatherSystem.Factory
{
    public class SnowWeatherBot : IBotFactory
    {
        public bool Enabled { get; set; }
        public double TempretureThreshold { get; set; }
        public string? Message { get; set; }

        public SnowWeatherBot()
        {

        }

        public bool DisplayMessage(WeatherDTO weather)
        {
            bool valueExceed = weather.Temperature < TempretureThreshold;
            if (Enabled && valueExceed)
            {
                Console.WriteLine(Message);
                return true;
            }
            return false;
        }
    }
}