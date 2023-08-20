using System.Text.Json;
using WeatherSystem.Models;

namespace WeatherSystem.Strategies
{
    public class JsonStrategy : IStrategy
    {
        public WeatherDTO ReadData(string input)
        {
            return JsonSerializer.Deserialize<WeatherDTO>(input);
        }
    }
}