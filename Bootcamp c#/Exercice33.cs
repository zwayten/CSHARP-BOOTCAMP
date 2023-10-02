using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice33
    {
        public static void Run()
        {
            Console.WriteLine("Input a number :");

            int number = Int32.Parse(Console.ReadLine());

            if(number >0 && ( number % 3 ==0 || number % 7 ==0))
            {
                Console.WriteLine(true);
            } else {
                Console.WriteLine(false);
            }
        }
    }
}
