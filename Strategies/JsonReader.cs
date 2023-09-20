using System.Text.Json;
using WeatherSystem.Models;

namespace WeatherSystem.Strategies
{
    public class JsonReader : IReader
    {
        public WeatherDTO ReadData(string input)
        {
            return JsonSerializer.Deserialize<WeatherDTO>(input);
        }
    }
}