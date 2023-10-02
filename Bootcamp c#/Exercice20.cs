using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice20
    {
        public static void Run()
        {
            Console.WriteLine("input first number :");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input second number :");
            int secondNumber = Int32.Parse(Console.ReadLine());

            int difference  = firstNumber - secondNumber;

            if( difference >= 0 )
            {
                Console.WriteLine($"the difference is |difference|*2 = {Math.Abs(difference)*2}");
            }
            else
            {
                Console.WriteLine($"the difference is |difference| = {Math.Abs(difference)}");
            }
        }
    }
}
