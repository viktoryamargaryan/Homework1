using System;

namespace problem5
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 4, 2, 7, 1, 9, 5 };

            Array.Reverse(numbers);

            Console.WriteLine("Reversed array: " + string.Join(", ", numbers));
        }
    }
}
