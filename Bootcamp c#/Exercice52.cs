using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice52 { 
        public static void Run()
        {
            int[] firstArray = { 1, 2, 5 };
            int[] secondArray = { 0, 3, 8 };
            int[] thirdArray = { -1, 0, 2 };

            int[][] arrays = { firstArray, secondArray, thirdArray };

            int[] result = new int[arrays.Length];


            for (int i = 0; i < arrays.Length; i++)
            {
                result[i] = arrays[i][arrays[i].Length /2];   
            }

            string resultOutput = string.Join(",", result);
            Console.WriteLine($"[{resultOutput}]");


        }
    }
}
