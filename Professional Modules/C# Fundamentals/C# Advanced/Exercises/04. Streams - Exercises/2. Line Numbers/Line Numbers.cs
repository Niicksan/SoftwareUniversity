using System;
using System.IO;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourse = @"../../../../files/text.txt";
            string destinationPath = @"../../../../files/output.txt";

            using (StreamReader streamReader = new StreamReader(sourse))
            {
                using (StreamWriter streamWriter = new StreamWriter(destinationPath))
                {
                    string line = streamReader.ReadLine();

                    int counter = 1;

                    while (line != null)
                    {
                        streamWriter.WriteLine($"Line {counter}: {line}");

                        counter++;

                        line = streamReader.ReadLine();
                    }
                }
            }
        }
    }
}
