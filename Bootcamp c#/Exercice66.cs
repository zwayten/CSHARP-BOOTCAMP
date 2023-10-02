using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
public class Exercice66
{
        public static void Run()
        {
            string x = "44";
            string y = "78";

            Console.WriteLine($"x = {x} | y = {y}");

            int min = Math.Min( Int32.Parse(x), Int32.Parse(y));

            Console.WriteLine($"the minimum is {min}");
        }
 
}
}
