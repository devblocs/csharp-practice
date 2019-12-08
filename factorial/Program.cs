using System;

namespace factorial
{
    class Program
    {
        public static double Fact(int num) {
            if(num == 1){
                return 1;
            }else{
                return num * Fact(num - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number to find factorial: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Factorial of number {num} is {Fact(num)}");
        }
    }
}
