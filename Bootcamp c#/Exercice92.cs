using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice92
    {

        public static int IsPrime(int n)
        {


            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) { n++; i = 2; }
            }
            return n;
        }
        public static void Run()
        {
            Console.WriteLine("Input a number :");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"Next Prime Number is : {IsPrime(x)}");

            Console.WriteLine($"next prime number is {x}");

        }
    }
}
