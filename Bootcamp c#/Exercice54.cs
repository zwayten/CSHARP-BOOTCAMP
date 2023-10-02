using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice54 {
        public static void Run()
        {
            Console.WriteLine("input the year :");

            int year = Int32.Parse(Console.ReadLine());

            int century = (year / 100) + ((year % 100 == 0) ? 0 : 1);

            Console.WriteLine($"Century of {year} is {century}");
        }
    }
}
