﻿using System;


namespace problem1
{
    internal class Program
    {

        static void Main()
        {
            Console.Write("Enter temperature in degrees Celsius: ");
            int temperature = int.Parse(Console.ReadLine());

            if (temperature < 0)
                Console.WriteLine("Freezing weather.");
            else if (temperature <= 10)
                Console.WriteLine("Cold weather.");
            else if (temperature <= 20)
                Console.WriteLine("Moderate weather.");
            else
                Console.WriteLine("Warm weather.");
        }
    }
}
