
namespace WeatherSystem.Factory
{
    public abstract class BotFactory
    {
        public abstract IBotFactory GetBot(string botType);
    }
}