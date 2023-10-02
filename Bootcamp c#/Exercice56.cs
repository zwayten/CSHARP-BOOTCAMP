using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice56 {
        public static void Run()
        {
            Console.WriteLine("Input a string :");
            string str = Console.ReadLine();

            string reversedString = new string(str.Reverse().ToArray());

            Console.WriteLine(reversedString == str ? "this is a plaindrome string": "this is not a palindrome string");
        }
    }
}
