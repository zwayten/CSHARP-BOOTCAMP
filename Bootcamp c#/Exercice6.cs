using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice6
    {
        public static void Run()
        {
            Console.WriteLine("First Number: ");
            string firstNumberStr = Console.ReadLine();
            int firstNumber = ParseStrToInt(firstNumberStr);

            Console.WriteLine("Second Number: ");
            string secondNumberStr = Console.ReadLine();
            int secondNumber = ParseStrToInt(secondNumberStr);

            Console.WriteLine("Third Number: ");
            string thirNumberStr = Console.ReadLine();
            int thirNumber = ParseStrToInt(thirNumberStr);

            int finalResult = 1;

            finalResult = firstNumber * secondNumber * thirNumber;
            Console.WriteLine($"{firstNumber} x {secondNumber} x {thirNumber} = {finalResult}");

        }

        public static int ParseStrToInt(string str)
        {
            try
            {
                int result = Int32.Parse(str);
                return result;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{str}'");
                return 0;
            }
        }
    }
}
