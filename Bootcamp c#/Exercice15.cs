using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice15
    {
        public static void Run()
        {
            Console.WriteLine("Enter a string :");
            string inputString = Console.ReadLine();

            if(inputString == null ) {
                Console.WriteLine("input a non empty string");

            }
            else
            {
                int stringLength = inputString.Length;
                Console.WriteLine($"Choose the index of the character to substitute from the string , you can't exceed {stringLength}");

                int index = Int32.Parse(Console.ReadLine());

                Console.WriteLine(inputString.Remove(index,1));

                
            }
        }
    }
}
