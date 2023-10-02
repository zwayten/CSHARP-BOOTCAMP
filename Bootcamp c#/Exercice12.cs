using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice12
    {
        public static void Run()
        {
            Console.WriteLine("Input a number : ");
            int number = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < 2; i++) 
            {
                Console.WriteLine("{0} {0} {0} {0}", number);
                Console.WriteLine("{0}{0}{0}{0}", number);



            }
        }
    }
}
