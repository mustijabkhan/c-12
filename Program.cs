// See https://aka.ms/new-console-template for more information


using System;

class TemperatureConverter
{
    static void Main(string[] args)
    {
        string choice;
        do
        {
            Console.WriteLine("Choose the temperature scale to convert from:");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.Write("Enter your choice: ");
            int scaleChoice = int.Parse(Console.ReadLine());

            double temperature;
            double convertedTemperature;

            if (scaleChoice == 1)
            {
                Console.Write("\nEnter the temperature in Celsius: ");
                temperature = double.Parse(Console.ReadLine());
                convertedTemperature = CelsiusToFahrenheit(temperature);
                Console.WriteLine($"{temperature}°C is equal to {convertedTemperature}°F.");
            }
            else if (scaleChoice == 2)
            {
                Console.Write("\nEnter the temperature in Fahrenheit: ");
                temperature = double.Parse(Console.ReadLine());
                convertedTemperature = FahrenheitToCelsius(temperature);
                Console.WriteLine($"{temperature}°F is equal to {convertedTemperature}°C.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose 1 or 2.");
            }

            Console.Write("\nDo you want to convert another temperature? (Y/N): ");
            choice = Console.ReadLine();
        } while (choice.ToUpper() == "Y");

        Console.WriteLine("\nThank you for using the temperature converter!");
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
