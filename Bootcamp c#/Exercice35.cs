using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice35
    {
        public static void Run()
        {
            Console.WriteLine("input first number :");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input second number :");
            int secondNumber = Int32.Parse(Console.ReadLine());

            bool check = firstNumber <100 && secondNumber > 100? true : false;

            Console.WriteLine(check);


        }
    }
}
