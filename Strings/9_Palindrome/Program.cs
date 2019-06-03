using System;

namespace _9_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome();

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
    }
}
