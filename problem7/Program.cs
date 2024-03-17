using System;


namespace problem7
{
    internal class Program
    {
        static void Main()
        {
            int[] array1 = { 7, 4, 3 };
            int[] array2 = { 8, 2, 6 };

            int[] sumArray = SumArrays(array1, array2);

            Console.WriteLine("Sum of corresponding elements:");
            Console.WriteLine("[" + string.Join(", ", sumArray) + "]");
        }

        static int[] SumArrays(int[] array1, int[] array2)
        {
            int length = Math.Min(array1.Length, array2.Length);
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = array1[i] + array2[i];
            }

            return result;
        }
    }
}
