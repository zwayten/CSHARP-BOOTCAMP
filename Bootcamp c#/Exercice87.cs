using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice87
    {
        public static void Run()
        {
            Console.WriteLine("Enter a boolean value (true or false):");
            string input = Console.ReadLine();
            if(bool.TryParse(input, out bool result))
            {
                Console.WriteLine("reserved vlaue: " + !result);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            }

        }
    }
}
