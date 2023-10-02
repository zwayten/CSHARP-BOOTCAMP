using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice48 {
        public static void Run()
        {
            int[] arrayInts = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            Console.WriteLine(arrayInts.First() == arrayInts.Last() ? true : false);
        }
    }
}
