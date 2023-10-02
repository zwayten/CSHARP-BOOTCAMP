using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice91
    {
        public static void Run()
        {
            Object[] array =
            {
                25, "Anna", -12, 34.68, System.DateTime.Now, true, false

            };

            int[] arrayInts = array.OfType<int>().ToArray();

            Console.WriteLine(string.Join(",",arrayInts));
        }
    }
}
