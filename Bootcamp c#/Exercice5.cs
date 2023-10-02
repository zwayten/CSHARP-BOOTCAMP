using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice5
    {
        public static void Run()
        {
            Console.WriteLine("Enter first number ");
            String firstNumber = Console.ReadLine();

            Console.WriteLine("Enter second number ");
            String secondNumber = Console.ReadLine();

            Console.WriteLine($"Inputs : \n firstNumber: {firstNumber} \n secondNumber: {secondNumber}");


            String tmpSwapper;

            tmpSwapper = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tmpSwapper;


            Console.WriteLine($"Output : \n firstNumber: {firstNumber} \n secondNumber: {secondNumber}");
        }
    }
}
