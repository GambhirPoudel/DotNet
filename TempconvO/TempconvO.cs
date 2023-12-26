using System;

class TempconvO
{
    public double CelsiusToFahrenheit(double celsius)
    {
        return (9.0 / 5.0) * celsius + 32;
    }
}

class Temp
{
    static void Main()
    {
        
        TempconvO converter = new TempconvO();

        Console.Write("Enter temperature in degrees Celcious: ");

        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = converter.CelsiusToFahrenheit(celsius);


        Console.WriteLine($"Temperature in degrees Fahrenheit: {fahrenheit:F2}");

    }
}
