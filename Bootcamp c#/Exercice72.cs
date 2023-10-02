using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice72
    {
        public static void Run()
        {
            int[] array = { 2, 4, 2, 6, 4, 8 };

            Console.WriteLine($" the average is : {array.Average()}");

            Console.WriteLine(array.Average() % 1 == 0 ? true : false);

        }
    }
}
