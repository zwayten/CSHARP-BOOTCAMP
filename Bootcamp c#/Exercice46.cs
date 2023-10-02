using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice46 
    { 
        public static void Run()
        {
            int[] numbersList = { 10, 25, 40, 37, 78, 44, 53, 67, 74, 8, 9, 12, 11 };

            Console.WriteLine("input a number : ");
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine(number == numbersList.First() || number == numbersList.Last() ? true : false );
        }
    }
}
