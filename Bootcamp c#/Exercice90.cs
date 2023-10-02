using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice90
    {
        public static void Run()
        {
            Console.WriteLine("input a number :");
            int x = int.Parse(Console.ReadLine());
            
            string binaryX = Convert.ToString(x, 2);

            int numberOfOnes = binaryX.Count(x => x == '1');
            int numberOfZeroes = binaryX.Count(x => x == '0');
            Console.WriteLine(binaryX);

            Console.WriteLine($" number of zeroes : {numberOfZeroes} ");
            Console.WriteLine($" number of ones : {numberOfOnes} ");
        }
    }
}
