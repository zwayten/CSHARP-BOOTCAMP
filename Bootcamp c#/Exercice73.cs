using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
    public class Exercice73
    {
        public static void Run()
        {
            Console.WriteLine( "input a String :" );
            string str = Console.ReadLine();    

            str = str.OrderBy( x => x ).ToString();
            Console.WriteLine(str);
        }
    }
}
