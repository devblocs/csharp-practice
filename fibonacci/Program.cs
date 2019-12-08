using System;

namespace fibonacci
{
    class Program
    {

        // print the fibonacci series in a recursive way
        public static int FibSeries(int num){
            if (num == 0) return 0;
            if(num == 1) return 1;

            return FibSeries(num - 1) + FibSeries(num - 2); // F(n) = F(n-1) + F(n-2)
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number for fibonacci series: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < num; i++){
                Console.Write($"{FibSeries(i)} ");
            }
        }
    }
}
