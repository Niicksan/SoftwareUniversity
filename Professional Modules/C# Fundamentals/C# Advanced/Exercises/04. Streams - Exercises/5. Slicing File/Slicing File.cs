using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace _5._Slicing_File
{
    class Program
    {
        static List<string> paths;

        static void Main(string[] args)
        {
            paths = new List<string>();

            string sourceFile = @"../../../../files/sliceMe.mp4";
            string destination = @"../../../../files/";

            int parts = 4;

            Slice(sourceFile, destination, parts);

            Assemble(paths, destination);
        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream readFIle = new FileStream(sourceFile, FileMode.Open))
            {
                long size = readFIle.Length / parts + readFIle.Length % parts;

                byte[] buffer = new byte[size];

                for (int i = 0; i < parts; i++)
                {
                    string destPath = destinationDirectory + $"Path{i}.mp4";

                    paths.Add(destPath);

                    int readedBytes = 0;

                    using (FileStream writeFile = new FileStream(destPath, FileMode.Create))
                    {
                        int bytesCount = readFIle.Read(buffer, 0, buffer.Length);
                        writeFile.Write(buffer, 0, buffer.Length);
                    }

                    using (GZipStream gz = new GZipStream(new FileStream(destPath + ".gz", FileMode.Create), CompressionMode.Compress, false))
                    {
                        gz.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }

        static void Assemble(List<string> paths, string destinationDirectory)
        {
            byte[] buffer = new byte[1024];
            destinationDirectory += "assemble.mp4";

            using (FileStream writeFile = new FileStream(destinationDirectory, FileMode.Create))
            {
                foreach (var path in paths)
                {
                    using (FileStream readFile = new FileStream(path, FileMode.Open))
                    {
                        while (true)
                        {
                            int bytesCount = readFile.Read(buffer, 0, buffer.Length);

                            if (bytesCount == 0)
                            {
                                break;
                            }

                            writeFile.Write(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }
    }
}
