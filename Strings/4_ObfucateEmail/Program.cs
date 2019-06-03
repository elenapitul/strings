using System;

namespace _4_ObfucateEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            //You have some text that contains your email address. And you want to hide that.
            //You decide to censor your email: to replace all characters in it with * except the domain.
            //Assume your email address will always be in format [username]@[domain].
            //You need to replace the username with * of equal number of letters and keep the domain unchanged.
            //You will get as input the email address you need to obfuscate.
            ObfucateEmail();
        }

        public static void ObfucateEmail()
        {
            Console.WriteLine("Please write an email address. ");
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s) || !s.Contains("@") || 
                s.EndsWith("@") || s.StartsWith("@"))
            {
                Console.WriteLine("Please write a correct email address.");
                s = Console.ReadLine();
            }

            int index = s.IndexOf('@');
            string obfucate = s.Substring(0, index);
            for (int i = 0; i < obfucate.Length; i++)
            {
                obfucate = obfucate.Replace(obfucate[i], '*');
            }

            Console.WriteLine(obfucate + s.Substring(index));                        
        }
    }
}
