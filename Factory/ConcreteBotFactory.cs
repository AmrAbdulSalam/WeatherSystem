
using WeatherSystem.Configuration;

namespace WeatherSystem.Factory
{
    public class ConcreteBotFactory : BotFactory
    {
        private WeatherConfiguration? _config = ReadConfiguration.Configuration;
        public ConcreteBotFactory()
        {
        }

        public override IBotFactory GetBot(string botType)
        {
            return botType switch
            {
                "rain" => new RainWeather(){
                    Enabled = _config.RainBot.Enabled ,
                    HumidityThreshold = _config.RainBot.HumidityThreshold,
                    Message = _config.RainBot.Message
                },
                "sun" => new SunnyWeather()
                {
                    Enabled = _config.SunBot.Enabled,
                    TempretureThreshold = _config.SunBot.TemperatureThreshold,
                    Message = _config.SunBot.Message
                },
                "snow" => new SnowWeather()
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