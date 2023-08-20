using WeatherSystem;
using WeatherSystem.Factory;
using WeatherSystem.Models;
using WeatherSystem.Strategies;
using WeatherSystem.Validations;

namespace Weather
{
    public class Program
    {
        static async Task Main()
        {
            string configurationFile = @"/Users/amr/Desktop/Foothill-Internship/CleanCode/WeatherSystem/configuration.json";

            while (true)
            {
                await ReadConfiguration.ReadConfigurationFileAsync(configurationFile);
                Console.WriteLine("Enter weather data:");
                var weatherData = Console.ReadLine();
                WeatherDTO data;

                if (DataValidation.IsJson(weatherData))
                {
                    var context = new Context(new JsonStrategy());
                    data = context.ExecuteStrtegy(weatherData);
                }
                else if (DataValidation.IsXml(weatherData))
                {
                    var context = new Context(new XmlStrategy());
                    data = context.ExecuteStrtegy(weatherData);
                }
                else
                {
                    break;
                }

                var factory = new ConcreteBotFactory();


                var rainBot = factory.GetBot("rain");
                rainBot.DisplayMessage(data);

                var snowBot = factory.GetBot("snow");
                snowBot.DisplayMessage(data);


                var sunBot = factory.GetBot("sun");
                sunBot.DisplayMessage(data);

            }
        }
    }
}