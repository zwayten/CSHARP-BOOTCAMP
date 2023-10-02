using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice11
    {
        public static void Run()
        {
            Console.WriteLine($"Enter your age");
            int age = Int32.Parse( Console.ReadLine() );

            Console.WriteLine($"You look older than 25 {age}");
        }
    }
}
