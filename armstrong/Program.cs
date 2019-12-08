using System;

namespace armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0, temp;

            Console.Write("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;

            while(num > 0){
                rem = num%10;
                sum = sum + (rem*rem*rem);
                num = num/10;
            }

            if(temp == sum){
                Console.WriteLine($"{temp} is an armstrong number");
            }else{
                Console.WriteLine($"{temp} is not an armstrong number");
            }
        }
    }
}
