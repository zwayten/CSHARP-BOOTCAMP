using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
public class Exercice69
{
        static bool ContainsOnlyLowerCase(string input)
        {
            return Regex.IsMatch(input, "^[a-z]+$");
        }

        static bool ContainsOnlyUpperCase(string input)
        {
            return Regex.IsMatch(input, "^[A-Z]+$");
        }

        public static void Run()
        {

            Console.WriteLine("Input the string :");
            string str = Console.ReadLine();

            Console.WriteLine(ContainsOnlyLowerCase(str) ? "Lower case" : (ContainsOnlyUpperCase(str) ? "UpperCase": "mixed"));
        }
    }
}
