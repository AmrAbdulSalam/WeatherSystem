using WeatherSystem.Models;

namespace WeatherSystem.Strategies
{
    public interface IReader
    {
        public WeatherDTO ReadData(string input);
    }
}