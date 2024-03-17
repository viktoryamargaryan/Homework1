using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 13)
                Console.WriteLine("Child.");
            else if (age <= 19)
                Console.WriteLine("Teenager.");
            else
                Console.WriteLine("Adult.");
        }
    }
}
