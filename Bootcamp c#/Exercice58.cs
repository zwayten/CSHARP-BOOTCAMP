using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice58
    {
        public static void Run()
        {
            int[] array = { 1, 3, 4, 7, 9 };
            Array.Sort(array);

            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                counter += array[i + 1] - array[i] - 1;
            }
            Console.WriteLine($"number of number that are missign to complete the range is : {counter}");
        }
    }
}
