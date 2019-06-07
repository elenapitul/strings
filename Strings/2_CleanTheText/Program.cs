using System;

namespace _2_CleanTheText
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will get a text from where you will need to clean the text because it contains a lot of strange characters that don't belong there
            //( ^ <, > &+ @%$)
            //Input. : Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.
            CleanText();
        }

        public static void CleanText()
        {
            Console.WriteLine("Please write a string with strange characters. ");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }
            var cToRemove = new string[] { "^", "<", ">", "&", "+", "@", "%", "$" };

            foreach (var c in cToRemove)
            {
                s = s.Replace(c," ");
            }

            while (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
            }

            Console.WriteLine(s);

        }
    }
}
