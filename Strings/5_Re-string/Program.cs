using System;

namespace _5_Re_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method to get a string made of the first 2 and the last 2 chars from a given string.
            //If the string length is less than 2, return instead the empty string
            ReString();
        }

        public static void ReString()
        {
            Console.WriteLine("Please write a string. ");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }

            if (s.Length >= 2)
            {
                string res = string.Concat(s.Substring(0, 2), s.Substring(s.Length - 2, 2));
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine($"{null}");
            }
        }

    }
}
