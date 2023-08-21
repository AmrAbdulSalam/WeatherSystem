using WeatherSystem.Models;

namespace WeatherSystem.Strategies
{
    public class Context
    {
        private IReader _reader;

        public Context(IReader reader)
        {
            _reader = reader;
        }

        public WeatherDTO ExecuteStrtegy(string input)
        {
            return _reader.ReadData(input);
        }
    }
}