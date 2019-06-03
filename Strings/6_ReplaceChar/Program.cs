using System;

namespace _6_ReplaceChar
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeSymbol();
            SwapTwoChars();
            NotPoor();

        }
        //Write a method to get a string from a given string where 
        //all occurrences of its first char have been changed to "$", except the first char itself.
        public static void ChangeSymbol()
        {
            Console.WriteLine("Please write a string.");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }
            char c = s[0];
            string sub = s.Substring(1);
            for (int i = 0; i < sub.Length; i++)
            {
                if (sub[i] == c)
                {
                    sub = sub.Replace(sub[i], '$');
                }
            }
            Console.WriteLine(s[0] + sub);
        }

        //Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string.
        public static void SwapTwoChars()
        {
            Console.WriteLine("Please write a string.");
            string s1 = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s1))
            {
                Console.WriteLine("Please write a no empty string.");
                s1 = Console.ReadLine();
            }
            Console.WriteLine("Please write a string.");
            string s2 = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s2))
            {
                Console.WriteLine("Please write a no empty string.");
                s2 = Console.ReadLine();
            }

            string swaps1 = s1.Substring(0, 2);
            string swaps2 = s2.Substring(0, 2);

            string outs1 = swaps2 + s1.Substring(2);
            string outs2 = swaps1 + s2.Substring(2);

            Console.WriteLine($"{outs1} {outs2}");
        }

        //Write a method to find the first appearance of the substring 'not' and 'poor' from a given string.
        //If 'not' follows the 'poor', replace the whole 'not'...'poor' substring with 'good'.
        //Return the resulting string.
        public static void NotPoor()
        {
            Console.WriteLine("Please write a string.");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }

            string notS = "not";
            string poorS = "poor";
            if (s.Contains(notS) && s.Contains(poorS))
            {
                int part1 = s.IndexOf(notS, 0);
                int part2 = s.IndexOf(poorS, part1) + poorS.Length;
                string sub = s.Substring(part1, part2 - part1);
                s = s.Replace(sub, "good");
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine($"The string does not contain {notS} and {poorS}.");
            }
        }


    }
}
