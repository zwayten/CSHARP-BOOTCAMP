using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice22
    {
        public static void Run()
        {
            Console.WriteLine("input first number :");
            int number = Int32.Parse(Console.ReadLine());

            bool checkWithin = Math.Abs(100 -  number) <= 20 || Math.Abs(200 - number) <= 20 ? true : false;

            Console.WriteLine(checkWithin);




        }
    }
}
