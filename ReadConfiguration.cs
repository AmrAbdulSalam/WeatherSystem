using System.Text.Json;
using WeatherSystem.Configuration;

namespace WeatherSystem
{
    public static class ReadConfiguration
    {
        public static WeatherConfiguration? Configuration { get; set; }

        public static async Task ReadConfigurationFileAsync(string path)
        {
            using (var reader = new StreamReader(File.OpenRead(path)))
            {
                var jsonContent = await File.ReadAllTextAsync(path);
                Configuration = JsonSerializer.Deserialize<WeatherConfiguration>(jsonContent);
            }
               
        }
    }
}