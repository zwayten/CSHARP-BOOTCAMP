using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice28
    {
        public static void Run()
        {
            Console.WriteLine("input a string");
            string inputString = Console.ReadLine();

            string[] stingsTab = inputString.Split(new[] {" "}, StringSplitOptions.None);

            string outputString = "";
            for (int i = stingsTab.Length - 1 ; i >= 0; i--)
            {
                outputString += stingsTab[i] + " ";
                outputString += " ";
            }

            Console.WriteLine($"Input string : {inputString}");
            Console.WriteLine($"Output string : {outputString}");

        }
    }
}
