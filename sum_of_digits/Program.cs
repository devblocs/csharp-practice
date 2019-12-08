using System;

namespace sum_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rem, temp, sum = 0;

            Console.Write("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());

            temp = num;

            while(num > 0){
                rem = num%10;
                sum = sum + rem;
                num = num / 10;
            }

            Console.WriteLine($"Given number is: {temp}");
            Console.WriteLine($"The sum of all digits in {temp} is {sum}");
        }
    }
}
