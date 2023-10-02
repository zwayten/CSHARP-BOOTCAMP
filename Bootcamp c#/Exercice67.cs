using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
public class Exercice67
{
        public static void Run()
        {
            Console.WriteLine("Input the string to encode :");
            string str = Console.ReadLine();

            char[,] key = {
            { '9', '0', '1', '6', '8' },
            { 'P', 'T', 'S', 'H', 'A' }
            };

            char[] encodedChars = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                for(int j = 0; j < key.GetLength(1); j++)
                {
                    if (encodedChars[i] == key[1,j])
                    {
                        encodedChars[i] = key[0, j];
                        break;
                    }
                    
                }
            }

            string encodedStr = new string(encodedChars);

            Console.WriteLine($"regular string {str}");
            Console.WriteLine($"Encoded string {encodedStr}");

        }
 
}
}
