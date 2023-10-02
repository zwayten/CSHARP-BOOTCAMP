using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice50 {
    
        public static void Run()
        {
            int[] array = { 1, 2, 8 };

            Array.Reverse(array);

            foreach (int i in array)
            Console.Write($"{i} ");
        }
    }
}
