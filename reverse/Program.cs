using System;

namespace reverse
{
    class Program
    {
        public static void ReverseInt(int num){
            int rem, revs = 0, temp;

            temp = num;

            while(num > 0){
                rem = num%10;
                num = num/10;
                revs = revs*10 + rem;
            }

            Console.WriteLine($"The reverse of number {temp} is {revs}");
        }

        public static void ReverseString(string text){
            string revs = "";

            for(int i = text.Length-1; i >= 0; i--){
                revs += text[i].ToString();
            }

            Console.WriteLine($"Reverse of string \"{text}\" is \"{revs}\"");
        }
        
        static void Main(string[] args)
        {   
            Console.WriteLine("Please select one option below:");
            Console.WriteLine("1) Int");
            Console.WriteLine("2) String");
            Console.Write("Enter your desired option (1 or 2): ");
            int select_palindrome = Convert.ToInt32(Console.ReadLine());

            if(select_palindrome == 1){
                 Console.Write("Enter the number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                ReverseInt(num);            
            }else if(select_palindrome == 2){
                Console.Write("Enter the string: ");
                string text = Console.ReadLine();

                ReverseString(text);
            }else{
                Console.WriteLine("Invalid Entry");
            }
        }
    }
}
