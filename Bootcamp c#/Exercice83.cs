using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice83
    {
        public static void Run()
        {
            Console.WriteLine("input a string : ");
            string str = Console.ReadLine();

            string pattern = @"[aeiouyAEIOUY]";

            string result = Regex.Replace(str, pattern, "");

            Console.WriteLine(result);
        }
    }
}
