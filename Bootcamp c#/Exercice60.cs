using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
        // j  j  j  j
        //[X, 2, 3, 2], i
        //[X, 6, X, 1], i
        //[X, X, X, X]  i
    public class Exercice60 { 
    public static void Run()
        {
            int[,] matrix = new int[3, 4]{
                                            { 0, 2, 3, 2 },
                                            { 0, 6, 0, 1 },
                                            { 4, 0, 3, 0 }
                                         };

            int sum = 0;

            Console.WriteLine($"number of rows : {matrix.GetLength(0)}");
            Console.WriteLine($"number of columns : {matrix.GetLength(1)}");

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0) && matrix[j,i] >0 ; j++)
                {
                    if (matrix[j, i] != 0) 
                    { 
                        sum += matrix[j, i];
                    } 
                }
            }
            Console.WriteLine($"sum is : {sum}");


        }
    }
}
