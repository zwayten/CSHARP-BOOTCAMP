using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_c_
{
    public class Exercice29
    {
        public static string FilePath  = @"C:\Users\zwayt\OneDrive\Documents\GitHub\Bootcamp c#\Bootcamp c#\Files\dummyfileEx29.txt";
        public static void Run()
        {
            if (File.Exists(FilePath))
            {
                FileInfo fileInfo = new FileInfo(FilePath);
                long fileSize = fileInfo.Length;

                Console.WriteLine($"File size is {fileSize} Bytes.");
            } else { Console.WriteLine("file does not exist"); }
        }
    }
}
