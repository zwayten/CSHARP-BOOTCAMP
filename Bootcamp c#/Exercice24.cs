using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice24
    {
        public static void Run()
        {
            Console.WriteLine("Enter a String");
            string inputString = Console.ReadLine();

            string[] listOfWords = inputString.Split(new[] { " " }, StringSplitOptions.None);

            

            string longestWord = "";
            for(int i = 0; i < listOfWords.Length; i++)
            {
                if (listOfWords[i].Length > longestWord.Length)
                {
                    longestWord = listOfWords[i];
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}
