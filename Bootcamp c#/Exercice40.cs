using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice40
    {
        public static void Run()
        {
            Console.WriteLine("input first number :");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input second number :");
            int y = Int32.Parse(Console.ReadLine());

            int number = 20;


            var val1 = Math.Abs(x - number);
            var val2 = Math.Abs(y - number);
            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
            //if(x == y)
            //{
            //    Console.WriteLine(0);
            //}
            //if(number - x < number - y)
            //{
            //    Console.WriteLine(x);
            //}
            //if (number - x < number - y)
            //{
            //    Console.WriteLine(y);
            //}
        }
    }
}
