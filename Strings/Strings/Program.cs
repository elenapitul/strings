using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //RemoveN(); //1
            //RemoveOdd(); //2
            //UpLowCases(); //3
            //ReverseFour(); //4
            //UpperCase(); //5
            //Newline(); //6
            //FormattedOutput(); //7
            //FormatPercentage(); //8
            //ReverseString(); //9
            //StripChar(); //10
            //LowercaseN(); //11
            //CapitalizeFirstLast(); //12
            SumDigitsString(); //13
        }


        //1. Write a method that removes the nth index character from a nonempty string.
        public static void RemoveN()
        {
            Console.WriteLine("Please write a string for exercise 1.");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }

            StringBuilder sb = new StringBuilder(s);
            Console.WriteLine("Which index should be removed?");
            sb.Remove(int.Parse(Console.ReadLine()), 1);
            s = sb.ToString();
            Console.WriteLine(s);
        }

        //2.nWrite a method that removes the characters which have odd index values of a given string.
        public static void RemoveOdd()
        {
            Console.WriteLine("Please write a string for exercise 2.");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }

            StringBuilder sb = new StringBuilder(s);
            for (int i = 1; i < sb.Length; i++)
            {
                sb.Remove(i, 1);
            }

            s = sb.ToString();
            Console.WriteLine(s);

        }

        //3. Write a method that takes input from the user and displays that input back in upper and lower cases.
        public static void UpLowCases()
        {
            Console.WriteLine("Please write a string for exercise 3.");
            string s = Console.ReadLine();
            while (string.IsNullOrEmpty(s) == true || (s.Any(char.IsLetter) == false))
            {
                Console.WriteLine("Please write a string not empty and without digits.");
                s = Console.ReadLine();
            }

            Console.WriteLine($"{s} in upper cases is {s.ToUpper()} " +
                $"and in lower cases is {s.ToLower()}");
        }

        //4. Write a method that reverses a string if it's length is a multiple of 4
        public static void ReverseFour()
        {
            Console.WriteLine("Please write a string for exercise 4.");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }
            int length = s.Length - 1;
            string reverse = "";
            while ((length >= 0) && (s.Length % 4 == 0))
            {
                reverse = reverse + s[length];
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

        }

        //5. Write a method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
        public static void UpperCase()
        {
            Console.WriteLine("Please write a string for exercise 5.");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }

            if (s.Substring(0, 4).Any(char.IsUpper))
            {
                Console.WriteLine(s.ToUpper());
            }
            else
            {
                Console.WriteLine("The string is wrong from this exercise.");
            }


        }

        //6. Write a method that removes a newline.
        public static void Newline()
        {
            Console.WriteLine("Please write a string for exercise 4.");
            string s1 = Console.ReadLine();
            string newline = Environment.NewLine;
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();

            string finaltext = s1 + " " + Environment.NewLine + s2 + " " + Environment.NewLine + s3;

            Console.WriteLine(finaltext);
            string noNewLines = finaltext.Replace(Environment.NewLine, "");

            Console.WriteLine();
            Console.WriteLine(noNewLines);
        }

        //7. Write a method to display formatted text (width=50) as output.
        public static void FormattedOutput()
        {
            Console.WriteLine("Please write a string for exercise 7.");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < sb.Length; i++)
            {
                if (i % 50 == 0)
                {
                    sb.Insert(i, '\n');
                }
            }
            s = sb.ToString();
            Console.WriteLine(s);

        }

        //8. Write a method that formats a number with a percentage.
        public static void FormatPercentage()
        {
            Console.WriteLine("Please write a number for exercise 8.");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The percent format is: " + number.ToString("P", CultureInfo.InvariantCulture));
        }

        //9. Write a method that reverses a string
        public static void ReverseString()
        {
            Console.WriteLine("Please write a string for exercise 9.");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }
            int length = s.Length - 1;
            string reverse = "";
            while (length >= 0)
            {
                reverse = reverse + s[length];
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

        }

        //10. Write a method that strips a set of characters from a string.
        public static void StripChar()
        {
            Console.WriteLine("Please write a string for exercise 10.");
            string originalS = Console.ReadLine();
            if (string.IsNullOrEmpty(originalS))
            {
                Console.WriteLine("Please write a no empty string.");
                originalS = Console.ReadLine();
            }
            Console.WriteLine("Please add a set of characters from the string");
            string removeChars = Console.ReadLine();
            if (string.IsNullOrEmpty(removeChars) && originalS.Contains(removeChars))
            {
                Console.WriteLine("Please write a correct string.");
                removeChars = Console.ReadLine();
            }

            string returnString = originalS;
            char[] charAry = removeChars.ToCharArray();
            foreach (char c in charAry)
            {
                while (returnString.IndexOf(c) > -1)
                {
                    returnString = returnString.Remove(returnString.IndexOf(c), 1);
                }
            }

            Console.WriteLine(returnString);
        }

        //11. Write a method that transforms to lowercase first n characters in a string.
        public static void LowercaseN()
        {
            Console.WriteLine("Please write a string for exercise 11.");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }

            Console.WriteLine("Please write how many characters should be lowercased.");
            int nChar = int.Parse(Console.ReadLine());
            string newS = s.Substring(0, nChar).ToLower() + s.Substring(nChar);
            Console.WriteLine(newS);

        }

        //12. Write a method to capitalize first and last letters of each word of a given string.
        public static void CapitalizeFirstLast()
        {
            Console.WriteLine("Please write a string for exercise 12.");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Please write a no empty string.");
                s = Console.ReadLine();
            }
            var split = s.Split(' ');
            for (int i = 0; i < split.Length; i++)
            {
                split[i] = split[i].Substring(0, 1).ToUpper() + split[i].Substring(1) + split[split.Length - 1].Substring(0, 1).ToUpper();
            }

            var final_string = string.Join(" ", split);
            Console.WriteLine(final_string);

        }

        //13. Write a method to compute sum of digits of a given string (if any).
        public static void SumDigitsString()
        {
            Console.WriteLine("Please write a string for exercise 13.");
            string s = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s) == true && s.Any(char.IsDigit) == false)
            {
                Console.WriteLine("Please write a no empty string with at least one number.");
                s = Console.ReadLine();
            }
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > '0' && s[i] <= '9')
                {
                    Console.WriteLine(s[i]);
                    sum += s[i] - '0';
                }
            }
            Console.WriteLine($"Sum of digit is {sum}");
        }

    }
}
