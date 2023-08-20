using WeatherSystem.Models;

namespace WeatherSystem.Strategies
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public WeatherDTO ExecuteStrtegy(string input)
        {
            return _strategy.ReadData(input);
        }
    }
}