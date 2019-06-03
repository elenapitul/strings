using System;

namespace _7_LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestWord();
        }

        //Write a method that takes a list of words and returns the length of the longest one.
        public static void LongestWord()
        {
            Console.WriteLine("List a string of words.");
            string words = Console.ReadLine();
            int longest = 0;
            string longest_word = "";
            foreach(var word in words.Split())
            {
                if(word.Length > longest)
                {
                    longest = word.Length;
                    longest_word = word;
                }
            }
            Console.WriteLine($"The longest word is {longest_word} which has the length {longest}");                 
           
        }
    }
}
