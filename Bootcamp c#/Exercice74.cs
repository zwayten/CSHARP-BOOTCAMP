using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
public class Exercice74
{
 public static void Run()
        {
            Console.WriteLine("input string");

            string str = Console.ReadLine();

            Console.WriteLine( str.Length % 2 == 0 ? "Even length" : "odd lenght" );
        }
}
}
