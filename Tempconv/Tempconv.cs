using System;

class Temoconv
{
    static void Main()
    {

        Console.Write("Enter temperature in degrees celcious: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (9.0 / 5.0) * celsius + 32;
        Console.WriteLine($"Temperature in degrees Fahrenheit: {fahrenheit:F2}");

    }
}
