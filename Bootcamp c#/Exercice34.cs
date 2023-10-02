using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice34
    {
        public static void Run()
        {
            Console.WriteLine("input your string :");
            string inputString = Console.ReadLine();

            Console.WriteLine("Input the word : ");
            string inputWord = Console.ReadLine();

            int firstSpaceIndex = inputString.IndexOf(" ");

            string firstWord = inputString.Substring(0,firstSpaceIndex) ;

            Console.WriteLine(firstWord == inputWord);
        }
    }
}
