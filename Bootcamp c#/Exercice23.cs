using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice23
    {
        public static void Run()
        {
            Console.WriteLine("Enter a String");
            string inputString = Console.ReadLine();

            inputString = inputString.ToLower();
            Console.WriteLine(inputString);
        }
    }
}
