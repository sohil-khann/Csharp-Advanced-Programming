namespace PracticeProblems.App;

public class TemperatureConverter//
{
    public double CelsiusToFahrenheit(double celsius)// Method to convert Celsius to Fahrenheit
    {
        return (celsius * 9 / 5) + 32;
    }

    public double FahrenheitToCelsius(double fahrenheit)// Method to convert Fahrenheit to Celsius
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
