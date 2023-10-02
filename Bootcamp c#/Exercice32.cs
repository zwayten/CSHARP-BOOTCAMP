using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice32
    {
        public static void Run()
        {
            Console.WriteLine("Input a string: ");
            string inputString = Console.ReadLine();
            
            if(inputString.Length < 4 ) {
                Console.WriteLine(inputString);
            }
            else
            {
                string lastString = inputString.Substring(inputString.Length -4, 4);

                string finalString = "";
                for(int i = 0; i < 4; i++)
                {
                    finalString += lastString;
                }
                Console.WriteLine(finalString);
            }
        }
    }
}
