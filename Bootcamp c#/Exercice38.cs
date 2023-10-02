using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice38
    {
        public static void Run()
        {
            Console.WriteLine("input a string");
            string inputString = Console.ReadLine();
            if(inputString.Length < 2 ) 
            {
                Console.WriteLine("string too short");
            }
            else
            {
                string result = "";
                result += inputString[0] == 'P' ?  inputString[0].ToString() : "";
                result += inputString[1] == 'H' ? inputString[1].ToString() : "";

                Console.WriteLine(result);
            }


        }
    }
}
