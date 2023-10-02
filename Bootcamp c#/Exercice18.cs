using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice18
    {
        public static void Run()
        {
            Console.WriteLine("input first number :");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input second number :");
            int secondNumber = Int32.Parse(Console.ReadLine());

            bool checkNegativity = firstNumber*secondNumber < 0 ? true :false;

            Console.WriteLine(checkNegativity);


        }
    }
}
