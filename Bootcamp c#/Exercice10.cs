using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice10
    {
        public static void Run()
        {
            Console.WriteLine("Enter x value :");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter y value :");
            int y = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter z value :");
            int z = Int32.Parse(Console.ReadLine());

            int firstFormula = (x + y)*z;
            int secondFormula = x*y + y*z;
            Console.WriteLine($"(x + y)*z is {firstFormula}");
            Console.WriteLine($"x*y + y*z is {secondFormula}");
        }
    }
}
