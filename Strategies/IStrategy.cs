using WeatherSystem.Models;

namespace WeatherSystem.Strategies
{
    public interface IStrategy
    {
        public WeatherDTO ReadData(string input);
    }
}