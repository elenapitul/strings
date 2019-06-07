using System;
using System.Linq;
using System.Text;

namespace _9_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Palindrome();
            //Palindrome_Var2();
            Palindrome_Var3();

        }

        //Check if a string is palindrome (same value read from left to right and right to left)
        public static void Palindrome()
        {
            Console.WriteLine("Please write a string. ");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }
            string reverse = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse += s[i].ToString();
            }

            Console.WriteLine(reverse);
            Console.WriteLine();

            if (s == reverse)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

        public static void Palindrome_Var2()
        {
            Console.WriteLine("Please write a string. ");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please write a good string for this problem.");
                s = Console.ReadLine();
            }

            int length = s.Length - 1;
            string reverse = "";
            while (length >= 0)
            {
                reverse += s[length];
                length--;
            }

            if (string.IsNullOrWhiteSpace(reverse))
            {
                Console.WriteLine("The string has the wrong length for this exercise.");
            }
            else
            {
                Console.WriteLine($"Reverse string of {s} is {reverse}.");
            }

            if (s == reverse)
            {
                Console.WriteLine("Is Palindrome.");
            }
            else
            {
                Console.WriteLine("Is not Palindrome.");
            }
        }

        public static void Palindrome_Var3()
        {
            Console.WriteLine("Please write a string. ");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please write a good string for this problem.");
                s = Console.ReadLine();
            }

            string reverse = new string(s.Reverse().ToArray());
            if (s == reverse)
            {
                Console.WriteLine($"{s} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{s} is not Palindrome.");
            }


        }
    }
}
