using System;

namespace recursion
{
    class Program
    {
        static void Main()
        {
            // StringReverse();
            // Palindrome();
            // Decimal2Binary();
            // SumOfNaturalNumbers();
            BinarySearch();
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

        public static void Decimal2Binary()
        {
            Console.WriteLine("Enter a whole number that you want to convert to binary:");
            int num = int.Parse(Console.ReadLine());
            string result = "";
            Console.WriteLine($"{num} as a binary is {getBinary(num, result)}");
            static string getBinary(int num, string result)
            {
                if (num == 0)
                    return result;
                result = num % 2 + result;
                return getBinary(num / 2, result);

            }
        }

        public static void SumOfNaturalNumbers()
        {
            Console.WriteLine("Enter a natural number and I will Sum it:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of {num} is {sumNum(num)}");

            static int sumNum(int num)
            {
                if (num <= 1)
                    return num;
                return num + sumNum(num - 1);
            }


        }

        public static void BinarySearch()
        {
            int[] A = { -3, 0, 2, 5, 7, 10, 11, 18, 22, 43, 56, 67 };

            Console.WriteLine($"Given the array [-3, 0, 2, 5, 7, 10, 11, 18, 22, 43, 56, 67] pick a number and I will return its index:");
            int num = int.Parse(Console.ReadLine());
            int left = 0;
            int right = A.Length - 1;

            Console.WriteLine($"{num} is in index {binSearch(A, left, right, num)}");

            static int binSearch(int[] A, int left, int right, int num)
            {

                if (left > right)
                {
                    return -1;
                }

                int mid = (left + right) / 2;

                if (num == A[mid])
                {
                    return mid;
                }

                if (num < A[mid])
                {
                    return binSearch(A, left, mid - 1, num);
                }

                return binSearch(A, mid + 1, right, num);

            }

        }
    }
}
