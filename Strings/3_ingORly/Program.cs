using System;

namespace _3_ingORly
{
    class Program
    {
        static void Main(string[] args)
        {
            IngLy();
            //Write a method to add 'ing' at the end of a given string (length should be at least 3).
            //If the given string already ends with 'ing' then add 'ly' instead.
            //If the string length of the given string is less than 3, leave it unchanged.
        }

        public static void IngLy()
        {
            Console.WriteLine("Please write a string.");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }

            if ((s.Length >= 3) && s.Substring(s.Length-3, 3) != "ing")
            {
                string s_ing = string.Concat(s, "ing");
                Console.WriteLine(s_ing);
            }
            else if ((s.Length >= 3) && s.Substring(s.Length - 3, 3) == "ing")
            {
                string s_ly = string.Concat(s, "ly");
                Console.WriteLine(s_ly);
            }
            else
            {
                Console.WriteLine(s);
            }                                       

        }
    }
}
