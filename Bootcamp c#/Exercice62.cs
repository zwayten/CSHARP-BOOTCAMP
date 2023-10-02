using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
public class Exercice62
{
       public static void Run()
        {
            Console.WriteLine("input a stirng with parantehese ex: He(llo) zwayten");
            string str = Console.ReadLine();

            int openParentheses = str.IndexOf("(");
            int closeParentheses =str.IndexOf(")");

            string subStr = str.Substring(openParentheses + 1, closeParentheses - openParentheses -1);

            string reversedSubStr = new string(subStr.Reverse().ToArray());
            //str = str.Remove(openParentheses +1, closeParentheses - openParentheses +1).Insert(openParentheses, reversedSubStr);
            //str = str.Insert(openParentheses, reversedSubStr);


            //str = str.Replace(subStr, reversedSubStr);

            //str = str.Remove(openParentheses, 1);
            //str = str.Remove(closeParentheses -1);

            str = str.Remove(openParentheses + 1, subStr.Length).Insert(openParentheses + 1, reversedSubStr);

            // Remove the parentheses
            str = str.Remove(openParentheses, 1).Remove(closeParentheses - 1, 1);
            str = str.Replace("(", "").Replace(")", "");

            Console.WriteLine(subStr);

            Console.WriteLine(str);
        }
}
}
