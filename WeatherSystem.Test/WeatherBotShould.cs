using AutoFixture;
using WeatherSystem.Factory;
using WeatherSystem.Models;

namespace WeatherSystem.Test
{
    public class WeatherBotShould
    {

        [Theory]
        [InlineData("Nablus", 10, 11)]
        public void Activate_RainBot_If_RainBot_Enabled_And_Humidity_GreaterThan_Threshold(string location, float temperetureThreshold, float humidityThreshold)
        {
            var fixture = new Fixture();
            var rainBot = fixture.Build<RainWeatherBot>()
                .With(x => x.Enabled, true)
                .With(x => x.Message, "This is a rain bot")
                .With(x => x.HumidityThreshold, 10)
                .Create();

            var data = new WeatherDTO
            {
                Location = location,
                Temperature = temperetureThreshold,
                Humidity = humidityThreshold
            };

            Assert.True(rainBot.DisplayMessage(data));
        }

        [Fact]
        public void Not_Activate_RainBot_When_Its_Disabled()
        {
            var fixture = new Fixture();
            var rainBot = fixture.Build<RainWeatherBot>()
                .With(x => x.Enabled, false)
                .With(x => x.Message, "This is a rain bot")
                .With(x => x.HumidityThreshold, 10)
                .Create();

            var data = new WeatherDTO();

            Assert.False(rainBot.DisplayMessage(data));
        }

        [Theory]
        [InlineData("Nablus", 5, 29)]
        public void Not_Activate_RainBot_When_Humidity_LessThan_Threshold(string location, float temperetureThreshold, float humidityThreshold)
        {
            var fixture = new Fixture();
            var rainBot = fixture.Build<RainWeatherBot>()
                .With(x => x.Enabled, true)
                .With(x => x.Message, "This is a rain bot")
                .With(x => x.HumidityThreshold, 30)
                .Create();

            var data = new WeatherDTO
            {
                Location = location,
                Temperature = temperetureThreshold,
                Humidity = humidityThreshold
            };

            Assert.False(rainBot.DisplayMessage(data));
        }

        [Theory]
        [InlineData("Nablus", 20, 11)]
        public void Activate_SunBot_If_SunBot_Enabled_And_Tempereture_GreaterThan_Threshold(string location, float temperetureThreshold, float humidityThreshold)
        {
            var fixture = new Fixture();
            var sunBot = fixture.Build<SunnyWeatherBot>()
                .With(x => x.Enabled, true)
                .With(x => x.Message, "This is a sun bot")
                .With(x => x.TempretureThreshold, 10)
                .Create();

            var data = new WeatherDTO
            {
                Location = location,
                Temperature = temperetureThreshold,
                Humidity = humidityThreshold
            };

            Assert.True(sunBot.DisplayMessage(data));
        }

        [Fact]
        public void Not_Activate_SunBot_When_Its_Disabled()
        {
            var fixture = new Fixture();
            var sunBot = fixture.Build<SunnyWeatherBot>()
                .With(x => x.Enabled, false)
                .With(x => x.Message, "This is a sun bot")
                .With(x => x.TempretureThreshold, 10)
                .Create();

            var data = new WeatherDTO();

            Assert.False(sunBot.DisplayMessage(data));
        }

        [Theory]
        [InlineData("Nablus", 5, 29)]
        public void Not_Activate_SunBot_When_Temperetrue_LessThan_Threshold(string location, float temperetureThreshold, float humidityThreshold)
        {
            var fixture = new Fixture();
            var sunBot = fixture.Build<SunnyWeatherBot>()
                .With(x => x.Enabled, true)
                .With(x => x.Message, "This is a sun bot")
                .With(x => x.TempretureThreshold, 30)
                .Create();

            var data = new WeatherDTO
            {
                Location = location,
                Temperature = temperetureThreshold,
                Humidity = humidityThreshold
            };

            Assert.False(sunBot.DisplayMessage(data));
        }


        [Theory]
        [InlineData("Nablus", -5, 11)]
        public void Activate_SnowBot_If_SnowBot_Enabled_And_Tempereture_LessThan_Threshold(string location, float temperetureThreshold, float humidityThreshold)
        {
            var fixture = new Fixture();
            var rainBot = fixture.Build<SnowWeatherBot>()
                .With(x => x.Enabled, true)
                .With(x => x.Message, "This is a snow bot")
                .With(x => x.TempretureThreshold, 8)
                .Create();

            var data = new WeatherDTO
            {
                Location = location,
                Temperature = temperetureThreshold,
                Humidity = humidityThreshold
            };

            Assert.True(rainBot.DisplayMessage(data));
        }

        [Fact]
        public void Not_Activate_SnowBot_When_Its_Disabled()
        {
            var fixture = new Fixture();
            var rainBot = fixture.Build<SnowWeatherBot>()
                .With(x => x.Enabled, false)
                .With(x => x.Message, "This is a snow bot")
                .With(x => x.TempretureThreshold, 10)
                .Create();

            var data = new WeatherDTO();

            Assert.False(rainBot.DisplayMessage(data));
        }

        [Theory]
        [InlineData("Nablus", 25, 29)]
        public void Not_Activate_SnowBot_When_Tempereture_GraterThan_Threshold(string location, float temperetureThreshold, float humidityThreshold)
        {
            var fixture = new Fixture();
            var rainBot = fixture.Build<SnowWeatherBot>()
                .With(x => x.Enabled, true)
                .With(x => x.Message, "This is a snow bot")
                .With(x => x.TempretureThreshold, 15)
                .Create();

            var data = new WeatherDTO
            {
                Location = location,
                Temperature = temperetureThreshold,
                Humidity = humidityThreshold
            };

            Assert.False(rainBot.DisplayMessage(data));
        }
    }
}