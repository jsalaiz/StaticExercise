using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"32 degrees Fahrenheit in Celsius is: {TempConverter.FahrenheitToCelsius(32)}");
            Console.WriteLine($"100 degrees Celsius in Fahrenheit is: {TempConverter.CelsiusToFahrenheit(100)}");
        }
    }
}
