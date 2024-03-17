using System;


namespace problem3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Select conversion direction:");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter temperature in Fahrenheit: ");
                double fahrenheit = double.Parse(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"Equivalent temperature in Celsius: {celsius} °C");
            }
            else if (choice == 2)
            {
                Console.Write("Enter temperature in Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"Equivalent temperature in Fahrenheit: {fahrenheit} °F");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}

