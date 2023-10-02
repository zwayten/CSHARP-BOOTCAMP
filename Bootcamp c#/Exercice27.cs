using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice27
    {
        public static void Run()
        {
            Console.WriteLine("Input and Integer");
            string  input = Console.ReadLine();
            int sum = 0;

            if (input.Length > 1)
            {
                List<int> ints = new List<int>();

                for(int i = 0; i < input.Length; i++)
                {
                    ints.Add(Int32.Parse(input[i].ToString()));
                    sum+= ints[i];
                }
            }

            else if (input.Length == 1) {
                Console.WriteLine(Int32.Parse(input));
            }

            else
            {
                Console.WriteLine("can not sum an empty");
            }

            Console.WriteLine(sum);
        }
    }
}
