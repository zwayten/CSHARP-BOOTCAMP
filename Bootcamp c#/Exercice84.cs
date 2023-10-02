
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice84
    {
        public static void Run()
        {
            Console.WriteLine("Input a string");
            string str = Console.ReadLine();
            string indexOfLowerCases = "";

            string pattern = @"[a-z]";
            for (int i = 0; i< str.Length; i++) {
                indexOfLowerCases += char.IsLower(str[i]) ? $"{i}, ": "";
            }
            Console.WriteLine(indexOfLowerCases);
        }
    }
}
