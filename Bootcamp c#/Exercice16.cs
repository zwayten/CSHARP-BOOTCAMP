using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice16
    {
        public static void Run()
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            string firstChar = inputString.Substring(0, 1);
            inputString = inputString.Remove(0,1);

            string lastChar = inputString.Substring(inputString.Length-1,1);
            inputString = inputString.Remove(inputString.Length - 1, 1);

            string result = lastChar+inputString+ firstChar;

            Console.WriteLine(result);
        }
    }
}
