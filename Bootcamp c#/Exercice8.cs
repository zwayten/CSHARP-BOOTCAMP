using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice8
    {
        public static void Run()
        {
            int[] multiplactionFactors = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Number to multiply: ");
            int nbToMultiply = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < multiplactionFactors.Length; i++)
            {
                Console.WriteLine($"{nbToMultiply} * {multiplactionFactors[i]} = {nbToMultiply * multiplactionFactors[i]}");
            }
        }
    }
}
