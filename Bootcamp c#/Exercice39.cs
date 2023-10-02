using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice39
    {
        public static void Run()
        {
            Console.WriteLine("input first number :");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input second number :");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input third number :");
            int z = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"max of ({x},{y},{z}) is {Math.Max(x, Math.Max(y, z))}");
            Console.WriteLine($"min of ({x},{y},{z}) is {Math.Min(x, Math.Min(y, z))}");
        }
    }
}
