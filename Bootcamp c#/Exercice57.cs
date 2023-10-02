using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice57 { 
    public static void Run()
        {
            int[] array = { 1, 2, 5, 7, -10, -10, 11, 6 };

            int highestProductValue = array[0] * array[1];
            

            for (int i = 1; i < array.Length - 2; i++) {

                highestProductValue = array[i] * array[i + 1] > highestProductValue ? array[i] * array[i + 1] : highestProductValue;
                
            }
            Console.WriteLine(highestProductValue);

        }
    }
}
