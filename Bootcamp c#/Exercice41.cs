using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice41
    {
        public static void Run()
        {
            Console.Write("Input a string (contains at least one 'w' char) : ");
            string str = Console.ReadLine();

            var count = str.Count(s => s == 'w');
            Console.WriteLine(count >=1 && count <=3);
        }
    }
}
