using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice31
    {
        public static void Run()
        {
            int[] array1 = { 1, 3, -5, 4 };
            int[] array2 = { 1, 4, -5, 2 };

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} x {array2[i]} = {array1[i] * array2[i]}");
                if (i < array1.Length - 1)
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
