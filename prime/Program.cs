using System;

namespace prime
{
    class Program
    {
        public static int PrimeNum(int num){

            int i;
            for(i = 2; i < num; i++){
                if(num%i == 0){
                    return 0;
                }
            }

            if(i == num){
                return 1;
            }

            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = PrimeNum(num);

            if(result == 0){
                Console.WriteLine($"{num} is not a prime number");
            }else{
                Console.WriteLine($"{num} is a prime number");
            }
        }
    }
}
