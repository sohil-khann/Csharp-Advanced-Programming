namespace PracticeProblems.Test;
using PracticeProblems.App;

public class TemperatureConverterTests
{
    private TemperatureConverter converter;

    [SetUp]
    public void Setup()
    {
        converter = new TemperatureConverter();
    }

    [Test]
    public void CelsiusToFahrenheit_ShouldConvertCorrectly()
    {
        double result = converter.CelsiusToFahrenheit(0);
        Assert.That(result, Is.EqualTo(32));
    }

    [Test]
    public void FahrenheitToCelsius_ShouldConvertCorrectly()
    {
        double result = converter.FahrenheitToCelsius(32);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void CelsiusToFahrenheit_WaterBoiling_ShouldReturn212()
    {
        double result = converter.CelsiusToFahrenheit(100);
        Assert.That(result, Is.EqualTo(212));
    }

    [Test]
    public void FahrenheitToCelsius_WaterBoiling_ShouldReturn100()
    {
        double result = converter.FahrenheitToCelsius(212);
        Assert.That(result, Is.EqualTo(100));
    }
}
