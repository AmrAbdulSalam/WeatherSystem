using WeatherSystem.Models;

namespace WeatherSystem.Factory
{
    public interface IBotFactory
    {
        public bool DisplayMessage(WeatherDTO weather);
    }
}