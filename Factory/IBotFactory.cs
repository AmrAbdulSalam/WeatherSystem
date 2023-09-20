using WeatherSystem.Models;

namespace WeatherSystem.Factory
{
    public interface IBotFactory
    {
        public void DisplayMessage(WeatherDTO weather);
    }
}