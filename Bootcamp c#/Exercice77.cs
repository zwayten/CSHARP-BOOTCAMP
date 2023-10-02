using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice77
    {
        public static void Run()
        {
            Console.WriteLine("input string");
            string str = Console.ReadLine();

            Console.WriteLine(test(str) ? "is plural? true" : "is plural? false" );
        }

        public static bool test(string word)
        {
            return word.EndsWith("s");
        }
    }
}
