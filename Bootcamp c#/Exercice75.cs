using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice75
    {
        public static void Run()
        {
            Console.WriteLine("insert a number :");

            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine(x % 2 == 1 ? x : 2 * x -1);
        }
    }
}
