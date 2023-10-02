using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice55 {

        public static void Run()
        {
            int[] array = { 1, 2, 5, 7, -10, -10, 11, 6 };

            int largestProductPair = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int productPair = array[i] * array[i + 1];

                largestProductPair = productPair > largestProductPair ? productPair : largestProductPair;


            }
            Console.WriteLine($"largest adjacent product pair is {largestProductPair}");
        }
    }
}

