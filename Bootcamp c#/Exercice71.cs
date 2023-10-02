using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice71
    {
        public static void Run()
        {
            Console.WriteLine("input a string : ");
            string str = Console.ReadLine();

            int index = 1;
            bool test = false;
            for (int i = 0; i< str.Length -1; i++)
            {
               test = str[i] == str[index] ? true : false;
                if (test)
                {
                    break;
                }
                else index++;

            }

            Console.WriteLine(test);
        }

    }
}
