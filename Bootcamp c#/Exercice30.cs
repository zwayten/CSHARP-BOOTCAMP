using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice30
    {
        public static void Run()
        {
            Console.WriteLine("Input hexadecimal number : ");
            string hexadecimalValue = Console.ReadLine();

            int decimalValue = Convert.ToInt32(hexadecimalValue, 16);
            Console.WriteLine(decimalValue);
        }
    }
}
