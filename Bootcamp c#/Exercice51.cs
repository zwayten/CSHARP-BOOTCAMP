using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice51 { 
    public static void Run()
        {
            int[] arrayInts = { 1, 2, 2, 3, 3, 400, 5, 6, 50, 7, 7, 7, 8, 8, 1 };
            int maxValue = arrayInts[0];

            for (int i = 1; i < arrayInts.Length; i++) { 
                maxValue = arrayInts[i] > maxValue ? arrayInts[i] : maxValue;
            }
            Console.WriteLine(maxValue);
        } 
    }
}
