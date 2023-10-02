using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice17
    {
        public static void Run()
        {
            Console.WriteLine("Enter a String");
            string inputString = Console.ReadLine();
            inputString = inputString.Substring(0,1) + inputString + inputString.Substring(0, 1);
            Console.WriteLine(inputString);
        }
    }
}
