using System;

namespace swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nBefore swapping: ");
            Console.WriteLine($"First number: {a}");
            Console.WriteLine($"Second number: {b} \n\n");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After swapping: ");
            Console.WriteLine($"First number: {a}");
            Console.WriteLine($"Second number: {b}");

        }
    }
}
