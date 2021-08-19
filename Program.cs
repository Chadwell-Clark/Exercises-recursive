using System;

namespace recursion
{
    class Program
    {
        static void Main()
        {
            // StringReverse();
            Palindrome();
        }
        static void StringReverse()
        {
            Console.WriteLine("Input a string to be reversed");
            var input = Console.ReadLine();
            // reverseString(input);
            var output = reverseString(input);
            Console.WriteLine(output);

            /// Method #1
            string reverseString(string input)
            {
                if (input == "")
                {
                    return "";
                }
                return reverseString(input.Substring(1)) + input[0];

            }

            ///   Method #2
            // static string reverseString(string input)
            // {
            //     if (input.Length > 0)
            //         return input[input.Length - 1] + reverseString(input.Substring(0, input.Length - 1));
            //     else
            //         return input;
            // }

            /// Method #3
            // static void reverseString(string input)
            // {
            //     if ((input == null) || (input.Length <= 1))
            //         Console.Write(input);

            //     else
            //     {
            //         Console.Write(input[input.Length - 1]);
            //         reverseString(input.Substring(0, (input.Length - 1)));
            //     }
            // }
        }

        public static void Palindrome()
        {
            Console.WriteLine("Input a string and I will tell you if it is a Palindrome");
            var input = Console.ReadLine();

            if (isPalindrome(input))
            {
                Console.WriteLine($"{input} is a palindrome");
            }
            else
            {

                Console.WriteLine($"{input} is NOT a palindrome");
            }


            static bool isPalindrome(string input)
            {
                if (input.Length <= 1)
                {
                    return true;
                }

                if (input[0] != input[input.Length - 1])
                {

                    return false;
                }
                return isPalindrome(input.Substring(1, input.Length - 2));


            }
        }
    }
}
