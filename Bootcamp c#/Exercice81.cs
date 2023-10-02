using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice81
    {
        public static void Run()
        {
            Console.WriteLine("input a 2 digit number : ");

            int x = Int32.Parse(Console.ReadLine());

            if(x >= 10 && x <= 99) {

                int tensDigit = x / 10;
                int onesDigit = x % 10;

                int result = onesDigit * 10 + tensDigit;

                Console.WriteLine($"Original value {x} | After swap : {result} | { (x > result ? "original value is still the highest " : (x < result ? "value after swap is the highest":" both are equal"))}");

            }
        }

    }
}
