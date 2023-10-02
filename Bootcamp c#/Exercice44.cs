using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice44
    {
        public static void Run()
        {
            Console.WriteLine("Input a string :");
            string str = Console.ReadLine();

            for(int i = 0; i< str.Length; i++)
            {
                if(i % 2 != 0)
                {
                    str = str.Remove(i,1);
                }
            }
            Console.WriteLine(str);
        }
    }
}
