using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice21
    {
        public static void Run()
        {
            Console.WriteLine("input first number :");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input second number :");
            int secondNumber = Int32.Parse(Console.ReadLine());

            bool checkTwenty = firstNumber == 20 || secondNumber == 20 || firstNumber+ secondNumber == 20 ? true : false;

            Console.WriteLine(checkTwenty);
        }
    }
}
