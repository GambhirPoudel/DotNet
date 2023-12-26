 
using System;
namespace temp
{


    public class Class1
    {
        public Class1()
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());


            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}°F");
        }
    }
}
