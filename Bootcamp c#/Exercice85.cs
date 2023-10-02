using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice85
    {

        public static string CumulativeSum(double[] array)
        {
            double sum = 0;
            string cumulativeSums = "";
            for (int i = 0; i < array.Length ; i++)
            {
                sum += array[i];
                cumulativeSums += sum + " ,";
            }
            return cumulativeSums;
        }
        public static void Run()
        {
            
            double[] nums = { 1, 3, 4, 5, 6, 7 };
            double[] nums1 = { 1.2, -3, 4.1, 6, -5.47 };

            Console.WriteLine(CumulativeSum(nums));
            Console.WriteLine(CumulativeSum(nums1));
        }
    }
}
