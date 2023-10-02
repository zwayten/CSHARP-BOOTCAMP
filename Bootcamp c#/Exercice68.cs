using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
public class Exercice68
{
        public static void Run()
        {

            Console.WriteLine("Input the string :");
            string str = Console.ReadLine();

            Console.WriteLine("input a char :");
            char c = Console.ReadLine()[0];

            int count = 0;
            for (int i = 0; i < str.Length; i++ )
            {
                count += str[i] == char.ToLower(c) || str[i] == char.ToUpper(c) ? 1 : 0;
            }
            Console.WriteLine( count);

        }
 
}
}
