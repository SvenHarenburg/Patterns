namespace Patterns.Observer;

public class WeatherData : ISubject
{
    private readonly List<IObserver> observers = [];

    public decimal Humidity { get; private set; }
    public decimal Pressure { get; private set; }
    public decimal Temperature { get; private set; }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(decimal newTemperature, decimal newHumidity, decimal newPressure)
    {
        Temperature = newTemperature;
        Humidity = newHumidity;
        Pressure = newPressure;
        MeasurementsChanged();
    }
}