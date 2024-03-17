using System;


namespace problem6
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 4, 2, 7, 1, 9, 5 };

            int secondLargest = FindSecondLargest(numbers);

            Console.WriteLine($"Second largest element: {secondLargest}");
        }

        static int FindSecondLargest(int[] array)
        {
            Array.Sort(array);
            return array[array.Length - 2];
        }
    }
}
