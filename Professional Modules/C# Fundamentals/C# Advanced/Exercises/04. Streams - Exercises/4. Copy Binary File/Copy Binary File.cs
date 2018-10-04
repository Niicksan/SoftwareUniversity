using System;
using System.IO;

namespace _4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"../../../../files/copyMe.png";
            string destinationPath = @"../../../../files/coppyMe-copy.png";

            using (FileStream readFile = new FileStream(sourceFile, FileMode.Open))
            {
                var size = readFile.Length;
                byte[] buffer = new byte[size];

                readFile.Read(buffer, 0, buffer.Length);

                using (FileStream writeFile = new FileStream(destinationPath, FileMode.Create))
                {
                    writeFile.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
