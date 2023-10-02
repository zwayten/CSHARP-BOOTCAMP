using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice82
    {
        public static void Run()
        {
            Console.WriteLine("Input a string :");
            string str = Console.ReadLine();

            string pattern = @"[^a-zA-Z]";
           
            string  result = Regex.Replace(str, pattern,"");
            Console.WriteLine(result);

            //string secondPattern = @"[a-zA-Z]";
            //string secondResult = Regex.Replace(str, secondPattern, "");
            //Console.WriteLine(secondResult);


        }
    }
}
