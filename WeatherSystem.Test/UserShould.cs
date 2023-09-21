using WeatherSystem.Strategies;

namespace WeatherSystem.Test
{

    public class UserShould
    {
        [Theory]
        [InlineData("Nablus" , 32 , 40.1)]
        public void Parse_JSON_Reurtn_Same_Location(string actualLocation , float actualTempreture , float actualHumidity)
        {
            var weatherData = $"{{\"Location\": \"{actualLocation}\", \"Temperature\": {actualTempreture}, \"Humidity\": {actualHumidity}}}";
            var context = new Context(new JsonReader());

            var data = context.ExecuteStrtegy(weatherData);

           Assert.Equal(data.Location , actualLocation);
        }


        [Theory]
        [InlineData("Nablus", 32, 40.1)]
        public void Parse_JSON_Reurtn_Same_Tempereture(string actualLocation, float actualTempreture, float actualHumidity)
        {
            var weatherData = $"{{\"Location\": \"{actualLocation}\", \"Temperature\": {actualTempreture}, \"Humidity\": {actualHumidity}}}";
            var context = new Context(new JsonReader());

            var data = context.ExecuteStrtegy(weatherData);

            Assert.Equal(data.Temperature, actualTempreture);
        }


        [Theory]
        [InlineData("Nablus", 32, 40.1)]
        public void Parse_JSON_Reurtn_Same_Humidity(string actualLocation, float actualTempreture, float actualHumidity)
        {
            var weatherData = $"{{\"Location\": \"{actualLocation}\", \"Temperature\": {actualTempreture}, \"Humidity\": {actualHumidity}}}";
            var context = new Context(new JsonReader());

            var data = context.ExecuteStrtegy(weatherData);

            Assert.Equal(data.Humidity, actualHumidity);
        }

        [Theory]
        [InlineData("Nablus", 32, 40.1)]
        public void Parse_XML_Reurtn_Same_Location(string actualLocation, float actualTempreture, float actualHumidity)
        {
            var weatherData = $"<WeatherData><Location>{actualLocation}</Location><Temperature>{actualTempreture}</Temperature><Humidity>{actualHumidity}</Humidity></WeatherData>";
            var context = new Context(new XmlReader());

            var data = context.ExecuteStrtegy(weatherData);

            Assert.Equal(data.Location, actualLocation);
        }

        [Theory]
        [InlineData("Nablus", 32, 40.1)]
        [InlineData("Nablus", 50.5, 11.01)]
        public void Parse_XML_Reurtn_Same_Tempereture(string actualLocation, float actualTempreture, float actualHumidity)
        {
            var weatherData = $"<WeatherData><Location>{actualLocation}</Location><Temperature>{actualTempreture}</Temperature><Humidity>{actualHumidity}</Humidity></WeatherData>";
            var context = new Context(new XmlReader());

            var data = context.ExecuteStrtegy(weatherData);

            Assert.Equal(data.Temperature, actualTempreture);
        }

        [Theory]
        [InlineData("Nablus", 32, 40.1)]
        public void Parse_XML_Reurtn_Same_Humidity(string actualLocation, float actualTempreture, float actualHumidity)
        {
            var weatherData = $"<WeatherData><Location>{actualLocation}</Location><Temperature>{actualTempreture}</Temperature><Humidity>{actualHumidity}</Humidity></WeatherData>";
            var context = new Context(new XmlReader());

            var data = context.ExecuteStrtegy(weatherData);

            Assert.Equal(data.Humidity, actualHumidity);
        }
    }
}