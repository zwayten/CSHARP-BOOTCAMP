using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice49 { 
    
        public static void Run()
        {
            int[] firstArrayInts = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] secondArrayInts = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

            Console.WriteLine(firstArrayInts.First() == secondArrayInts.First() || firstArrayInts.Last() == secondArrayInts.Last() ? true : false);
        }
    }
}
