using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice80
    {
        public static void Run()
        {
            Object[] array = {
            25, "heloo", false, 24.01, 'c' 
            };

            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine($"value : {array[i].ToString()} -> type : {array[i].GetType() }");
            }
        }
    }
}
