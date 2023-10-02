using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice37
    {
        public static void Run()
        {
            Console.WriteLine("Enter a string : ");
            string inputStrig = Console.ReadLine();

            bool check = inputStrig.Substring(1,2).Equals("HP") ? true : false;

            if(check)
            {
                inputStrig.Remove(1,2);
            }

            Console.WriteLine(inputStrig);
        }
    }
}
