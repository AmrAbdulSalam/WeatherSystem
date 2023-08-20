
namespace WeatherSystem.Validations
{
    public static class DataValidation
    {
        public static bool IsJson(string input)
        {
            return (input.StartsWith("{") && input.EndsWith("}"));
        }
    }
}