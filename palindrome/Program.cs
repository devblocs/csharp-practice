using System;

namespace palindrome
{
    class Program
    {
        public static void PalindromeNum(int num){
            int rem, sum = 0, temp;
            
            temp = num;

            while(num > 0){
                rem = num % 10;
                num = num / 10;
                sum = sum * 10 + rem;
            }

            string result_text = (temp == sum) ? "palindrome" : "not palindrome";

            Console.WriteLine($"{temp} is a {result_text} number");
        }

        public static void PalindromeString(string text){
            string revs = "";

            for(int i = text.Length-1; i >= 0; i--){
                revs += text[i].ToString();
            }

            string result_text = (revs == text) ? "palindrome" : "not palindrome";

            Console.WriteLine($"{revs} is a {result_text} string");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please select one option below:");
            Console.WriteLine("1) Int");
            Console.WriteLine("2) String");
            Console.Write("Enter your desired option (1 or 2): ");
            int select_palindrome = Convert.ToInt32(Console.ReadLine());

            if(select_palindrome == 1){
                goto IntGoto;                
            }else if(select_palindrome == 2){
                goto StringGoto;
            }else{
                Console.WriteLine("Invalid Entry");
            }


            IntGoto:
                Console.Write("Enter the number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                PalindromeNum(num);

            StringGoto:
                Console.Write("Enter the string: ");
                string text = Console.ReadLine();
                PalindromeString(text);
        }
    }
}
