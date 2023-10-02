using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice78
    {
        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            int sum = 0;

            for (int i = 0; i < array.Length; i++) { 
            sum += array[i] * array[i];
            }

            Console.WriteLine(sum);
        }
    }
}
