using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice53 {

        public static void Run()
        {
            int[] array = { 1, 2, 5 };

            int oddNumbersCounter = 0;

            oddNumbersCounter = array.Count(x => x % 2 != 0);

            Console.WriteLine( oddNumbersCounter > 0 ? true : false );


        }
    }
}
