using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
public class Exercice70
{
 public static void Run()
        {
            Console.WriteLine("Input the string :");
            string str = Console.ReadLine();

            str = str.Remove(str.Length - 1,1);
            str = str.Remove(0,1);

            Console.WriteLine(str);
        }
}
}
