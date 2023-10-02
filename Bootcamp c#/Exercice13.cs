using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice13
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number :");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0 || i == 4 || j == 0 || j == 2)
                    {
                        Console.Write(number); // Digit for the border
                    }
                    else
                    {
                        Console.Write(" "); // Empty space inside the rectangle
                    }
                }
                Console.WriteLine(); // adding rows
            }

        }
    }
}
