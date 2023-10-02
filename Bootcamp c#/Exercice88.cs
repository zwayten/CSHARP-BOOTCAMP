using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice88
    {
        public static void Run()
        {
            Console.WriteLine("input the number of sides of the polygon :");
            int nbOfSides =  Int32.Parse(Console.ReadLine());

            

            if (nbOfSides >= 3)
            {
                //(nbOfSides - 2) corresponds to number of trianle inside a polygon 
                int sumOfAngles = (nbOfSides - 2) * 180;
                Console.WriteLine($"The sum of interior angles of a {nbOfSides}-sided polygon is {sumOfAngles} degrees.");
            }
            else
            {
                Console.WriteLine("A polygon must have at least 3 sides.");
            }

            

        }
    }
}
