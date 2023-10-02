using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice36
    {
        public static void Run()
        {
            Console.WriteLine("input first number :");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input second number :");
            int secondNumber = Int32.Parse(Console.ReadLine());

            bool check  = Math.Abs(firstNumber) <= 10 && Math.Abs(secondNumber) <= 10 ? true : false;
            Console.WriteLine(check);
        }
    }
}
