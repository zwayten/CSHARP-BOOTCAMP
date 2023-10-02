using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice7
    {
        public static void Run()
        {
            Console.WriteLine("First Number :");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Second Number :");
            int secondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} + {secondNumber} = { firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} x {secondNumber} = {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            Console.WriteLine($"{firstNumber} mod {secondNumber} = {firstNumber % secondNumber}");


        }
    }
}
