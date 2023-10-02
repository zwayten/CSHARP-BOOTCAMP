using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice89
    {
        public static void Run()
        {
            int[] array = { 10, -11, 12, -13, 14, -18, 19, -20 };

            int nbPositive = 0;
            int nbNegative = 0;

            for (int i = 0; i < array.Length; i++)
            {
                nbPositive += array[i] >= 0 ? 1 : 0;
                nbNegative += array[i] < 0 ? 1 : 0;
            }
            Console.WriteLine($"number of positive values : {nbPositive}");
            Console.WriteLine($"number of negative values : {nbNegative}");
        }
    }
}
