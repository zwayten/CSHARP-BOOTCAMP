using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice9
    {
        public static void Run()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Input List size :");
            int listSize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input 4 Numbers : ");
            for (int i = 0; i < listSize; i++) 
            {
                Console.WriteLine($"input the {i + 1}");
                list.Add(Int32.Parse(Console.ReadLine()));
            }
            int finalResult = list.Sum(x => x);
            string strOutput = "";
            for (int i = 0;i < listSize; i++) {
                strOutput += list[i].ToString();
                if (i < listSize - 1) // Check if it's not the last element
                {
                    strOutput += "+";
                }

            }

            Console.WriteLine($"( {strOutput} ) / {listSize} = {finalResult / listSize}");
        }
    }
}
