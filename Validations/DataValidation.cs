
using System.Data.SqlTypes;
using System.Xml;

namespace WeatherSystem.Validations
{
    public static class DataValidation
    {
        public static bool IsJson(string input)
        {
            return (input.StartsWith("{") && input.EndsWith("}"));
        }

        public static bool IsXml(string input)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(input);
                return true;
            }
            catch (XmlException)
            {
                return false;
            }
        }
    }
}