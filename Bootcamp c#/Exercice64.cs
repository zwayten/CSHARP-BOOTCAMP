using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bootcamp_c_
{
public class Exercice64
{
        public static void Run()
        {
            string filePath;
            filePath = @"C:\Users\zwayt\OneDrive\Documents\GitHub\Bootcamp c#\Bootcamp c#\Files\dummyfileEx29.txt";

            if (File.Exists(filePath))
            {
                FileInfo fileInfo = new FileInfo(filePath);
                long fileSize = fileInfo.Length;
                string fileName = fileInfo.Name;
                string extension = fileInfo.Extension;

                Console.WriteLine($"File size is {fileSize} Bytes.");
                Console.WriteLine($"File name is {fileName}.{extension}");
            }
            else { Console.WriteLine("file does not exist"); }
        }
 
}
}
