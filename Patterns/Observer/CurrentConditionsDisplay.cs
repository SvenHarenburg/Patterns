namespace Patterns.Observer;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private decimal humidity;
    private decimal temperature;
    private readonly WeatherData weatherdata;

    public CurrentConditionsDisplay(WeatherData weatherdata)
    {
        this.weatherdata = weatherdata;
        weatherdata.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {temperature}C degrees and {humidity}% humidity.");
    }

    public void Update()
    {
        temperature = weatherdata.Temperature;
        humidity = weatherdata.Humidity;
        Display();
    }
}