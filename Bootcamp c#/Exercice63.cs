using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
public class Exercice63
{
        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, };

            int number = Int32.Parse(Console.ReadLine());

            int ctr = 0;
             ctr = array.Count(x => x == number);
            //other method 

             bool check = array.Contains(number);
            Console.WriteLine(check);

            Console.WriteLine(ctr > 0 ? true: false);
        }
}
}
