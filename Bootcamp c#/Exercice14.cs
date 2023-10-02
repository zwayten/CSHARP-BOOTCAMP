using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice14
    {
        public static double CelsiusToFahrenheit(int cel)
        {
            return (cel * 9 / 5) + 32;
        }

        public static double CelsiusToKelvin(int cel)
        {
            return cel + 273.15;
        }


        public static void Run()
        {
            Console.WriteLine("Enter a temperature in °C (Celsius) :");
            int celsiusValue = Int32.Parse(Console.ReadLine());

            double fahrenheitValue = CelsiusToFahrenheit(celsiusValue);
            double kelvinValue = CelsiusToKelvin(celsiusValue);

            Console.WriteLine($"Fahrenheit {fahrenheitValue} || Kelvin {kelvinValue}");




        }
    }
}
