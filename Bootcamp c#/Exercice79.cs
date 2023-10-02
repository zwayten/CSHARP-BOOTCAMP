using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice79
    {
        public static string FromIntToString(int x)
        {
            return x.ToString();
        }

        public static int FromStringToInt(string str)
        {
            return Int32.Parse(str);
        }


        public static void Run()
        {
            Console.WriteLine("input a number to conver to String :");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"result : {FromIntToString(x)} -> {FromIntToString(x).GetType()}");

            Console.WriteLine("Input a string to convert to a number :");
            string str = Console.ReadLine();
            Console.WriteLine($"result : {FromStringToInt(str)} -> {FromStringToInt(str).GetType()}");


        }

    }
}
