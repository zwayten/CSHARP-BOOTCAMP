using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice86
    {
        public static void Run()
        {
            Console.WriteLine("Input a string");
            string str = Console.ReadLine();
            string patternLetters = @"[a-z]";
            string patternDigits = @"[0-9]";

            int numberOfLetters = 0;
            int numberOfDigits = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (Regex.IsMatch(str[i].ToString(), patternLetters))
                {
                    numberOfLetters++;
                }
                if (Regex.IsMatch(str[i].ToString(), patternDigits))
                {
                    numberOfDigits++;
                }
            }
            Console.WriteLine($"number of letters : {numberOfLetters} | number of digits : {numberOfDigits}");

        }
    }
}
