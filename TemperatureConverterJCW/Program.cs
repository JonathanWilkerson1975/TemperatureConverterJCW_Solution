using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");

            Console.Write("Enter the temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select the conversion:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            int conversion = Convert.ToInt32(Console.ReadLine());

            double convertedTemperature = 0;
            switch (conversion)
            {
                case 1:
                    convertedTemperature = (temperature * 9 / 5) + 32;
                    break;
                case 2:
                    convertedTemperature = (temperature - 32) * 5 / 9;
                    break;
                default:
                    Console.WriteLine("Invalid conversion selected.");
                    return;
            }

            Console.WriteLine($"The converted temperature is: {convertedTemperature}");
        }
    }
}
