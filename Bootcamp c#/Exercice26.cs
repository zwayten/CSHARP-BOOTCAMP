using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice26
    {
        public static void Run()
        {
            int primeNumbersSum = 0;
            int primeNumber = 2;

            int cap = 0;

            while(cap < 500)
            {
                if (IsPrime(primeNumber))
                {
                    primeNumbersSum += primeNumber;
                    cap++;


                }
                primeNumber++;
                
            }
            

            //for (int i = 0; i < 500; i++)
            //{
            //    bool primeCheck = IsPrime(i); 
            //    if(primeCheck == true)
            //    {
            //        Console.WriteLine(i);
            //        primeNumbersSum += i; 
            //    }
            //}
            Console.WriteLine(primeNumbersSum);
        }

        public static bool IsPrime(int number)
        {
            

            if (number == 1 || number == 4)
            {
                return false;
            }
            if(number == 3 || number == 2) 
            {
                return true;
            }
            
            for(int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                } 
            }

            return true;
        }
    }
}
