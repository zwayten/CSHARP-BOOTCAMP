using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice61
    {
         public static void Run()
          {
            //initial array
            int[] array = { -5, 236, 120, 70, -5, -5, 698, 280 };
            Console.WriteLine($"input: [{string.Join(", ", array)}]");

            //the initial array without -5 sorted asc 
            int[] arrayCopy = array.Where(x => x!= -5).OrderBy(x => x).ToArray();
            Console.WriteLine($"copy after filter and sort : [{string.Join(", ", arrayCopy)}]");
            
            int ctr = 0;

            var result = array.Select(x => x != -5 ? arrayCopy[ctr++] : -5);
            Console.WriteLine($"output: [{string.Join(", ", result)}]");
            


          }
    }
}
