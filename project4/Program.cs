using System;


namespace project4
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 4, 2, 7, 1, 9, 5 };

            int max = numbers[0];
            int min = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;

                if (number < min)
                    min = number;
            }

            Console.WriteLine($"Maximum element: {max}");
            Console.WriteLine($"Minimum element: {min}");
        }
    }
}
