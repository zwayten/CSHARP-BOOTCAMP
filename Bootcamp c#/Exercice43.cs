using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice43
    {
        public static void Run()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            // Check if the string starts with "w" and is followed by "ww"
            bool startsWithWw = input.StartsWith("w") && input.Length >= 3 && input[1] == 'w' && input[2] == 'w';

            if (startsWithWw)
            {
                Console.WriteLine("The string starts with 'w' and is followed by 'ww'.");
            }
            else
            {
                Console.WriteLine("The string does not meet the criteria.");
            }
        }
    }
}
