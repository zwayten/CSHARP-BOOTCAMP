using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice45
    {
        public static void Run()
        {
            Console.WriteLine("input a number to count it's redundancy :");
            int number = Int32.Parse(Console.ReadLine());

            int[] numbersArray = { 1, 12, 13, 14, 15, 16, 32, 1, 12, 13, 14, 15, 16, 3, 4, 5, 6, 7, 8, 9, 12, 13, 14 ,10, 3, 4, 5, 1 };

            int numberRedundancy = numbersArray.Count(x => x == number);

            Console.WriteLine($"the number {number} was found {numberRedundancy} times");
        }
    }
}
