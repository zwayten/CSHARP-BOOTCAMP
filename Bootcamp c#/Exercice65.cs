using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
public class Exercice65
{
        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array.Length; i++) {
                Console.Write($"{array[i] * array.Length} ");
            }
        }
 
}
}
