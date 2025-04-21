using Patterns.Observer;

namespace Patterns.Tests.Observer;

public class Tests
{
    [Test]
    public void Demo()
    {
        var weatherData = new WeatherData();
        
        var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
        weatherData.SetMeasurements(15, 65, 30.4m);
        weatherData.SetMeasurements(17, 70, 29.7m);
        weatherData.SetMeasurements(19, 55, 27.1m);
    }
}