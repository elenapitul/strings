using System;

namespace _8_LastPart
{
    class Program
    {
        static void Main(string[] args)
        {
            PartBeforeChar();
            StartChar();
            CountingSubstrings();
            SwapCommaDot();
            RemoveSpaces();
        }

        //Write a method to get the last part of a string before a specified character.
        public static void PartBeforeChar()
        {
            Console.WriteLine("Please write a string. ");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }

            Console.Write("Write a character: ");
            char input = (Console.ReadKey().KeyChar);
            Console.WriteLine();
            while (!s.Contains(input))
            {
                Console.WriteLine("Please write a character found in the string. ");
                input = (Console.ReadKey().KeyChar);
                Console.WriteLine();
            }

            int stop = s.IndexOf(input);
            Console.WriteLine(s.Substring(0, stop));
        }

        //Write a method to check whether a string starts with specified characters.
        public static void StartChar()
        {
            Console.WriteLine("Please write a string. ");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }

            Console.Write("Write a character: ");
            char input = (Console.ReadKey().KeyChar);
            Console.WriteLine();
            while (!s.Contains(input))
            {
                Console.WriteLine("Please write a character found in the string. ");
                input = (Console.ReadKey().KeyChar);
                Console.WriteLine();
            }

            if (s[0] == input)
            {
                Console.WriteLine($"Yes, it starts with {input}");
            }
            else
            {
                Console.WriteLine($"No, it doesn't start with {input}");
            }

        }

        //Write a method to count occurences of a substring in a string
        public static void CountingSubstrings()
        {
            Console.WriteLine("Please write a string. ");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }

            Console.WriteLine("Please write a substring. ");
            string subs = Console.ReadLine();
            while (!s.Contains(subs))
            {
                Console.WriteLine("Please write a correct substring. ");
                subs = Console.ReadLine();
            }

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i).Length >= subs.Length)
                {
                    if (s.Substring(i, subs.Length).Equals(subs))
                    {
                        count++;
                        i += subs.Length - 1;
                    }
                }

            }
            Console.WriteLine($"The {subs} appears {count} times.");

        }

        //Write a method to swap comma and dot in a string.
        public static void SwapCommaDot()
        {
            Console.WriteLine("Please write a string. ");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }

            for(int i =0; i < s.Length; i++)
            {
                if(s[i] == ',')
                {
                    s = s.Remove(i, 1);
                    s = s.Insert(i, ".");
                } else if(s[i] == '.')
                {
                    s = s.Remove(i, 1);
                    s = s.Insert(i, ",");
                }
            }

            Console.WriteLine(s);
        }

        //Write a method to remove spaces from a given string.
        public static void RemoveSpaces()
        {
            Console.WriteLine("Please write a string. ");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }

            for(int i =0; i < s.Length; i++)
            {
                if(s[i] == ' ')
                {
                    s = s.Remove(i, 1);
                    s = s.Insert(i, "");
                }
            }

            Console.WriteLine(s);
        }

    }
}
