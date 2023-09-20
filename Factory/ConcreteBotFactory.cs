
using WeatherSystem.Configuration;

namespace WeatherSystem.Factory
{
    public class ConcreteBotFactory : BotFactory
    {
        private WeatherConfiguration? _config = ReadConfiguration.Configuration;
        public ConcreteBotFactory()
        {
        }

        public override IBotFactory GetBot(BotType botType)
        {
            return botType switch
            {
                BotType.RainBot => new RainWeatherBot()
                {
                    Enabled = _config.RainBot.Enabled,
                    HumidityThreshold = _config.RainBot.HumidityThreshold,
                    Message = _config.RainBot.Message
                },
                BotType.SunBot => new SunnyWeatherBot()
                {
                    Enabled = _config.SunBot.Enabled,
                    TempretureThreshold = _config.SunBot.TemperatureThreshold,
                    Message = _config.SunBot.Message
                },
                BotType.SnowBot => new SnowWeatherBot()
                {
                    Enabled = _config.SnowBot.Enabled,
                    TempretureThreshold = _config.SnowBot.TemperatureThreshold,
                    Message = _config.SnowBot.Message
                },
                _ => throw new NotImplementedException(),
            };
        }
    }
}