using System.Xml;
using WeatherSystem.Models;

namespace WeatherSystem.Strategies
{
    public class XmlReader : IReader
    {
        public XmlReader()
        {

        }

        public WeatherDTO ReadData(string input)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(input);

            XmlNodeList personNodes = xmlDoc.SelectNodes("/WeatherData");
            var weather = new WeatherDTO();
            foreach (XmlNode personNode in personNodes)
            {
                weather.Temperature = float.Parse(personNode.SelectSingleNode("Temperature").InnerText);
                weather.Humidity = float.Parse(personNode.SelectSingleNode("Humidity").InnerText);
                weather.Location = personNode.SelectSingleNode("Location").InnerText;
            }
            return weather;
        }
    }
}