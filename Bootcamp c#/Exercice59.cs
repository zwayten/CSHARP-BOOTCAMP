using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice59 { 
        
        public static void Run() {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] b = { 1, 2, 3, -1, 30, 30, 7, 8, 9 };
             bool test_a = false;
            bool test_b = false;

            if(a.Length <=2) {
                Console.WriteLine("a : true");
            }
            if (b.Length <= 2)
            {
                Console.WriteLine("b : true");
            }

           
            for (int i = 0; i < a.Length - 1; i++)
            {
                test_a = a[i] < a[i + 1] ? true :false;
                test_b = b[i] < b[i + 1] ? true : false;
            }

            Console.WriteLine(test_a);
            Console.WriteLine(test_b);
        }
    }
}
