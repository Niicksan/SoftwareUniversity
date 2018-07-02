using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstLine = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            char[] secondLine = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            int minLength = Math.Min(firstLine.Length, secondLine.Length);

            if (firstLine.Length == secondLine.Length)
            {
                for (int i = 0; i < firstLine.Length; i++)
                {
                    if (firstLine[i] > secondLine[i])
                    {
                        Console.WriteLine(string.Join("",secondLine));
                        Console.WriteLine(string.Join("", firstLine));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", firstLine));
                        Console.WriteLine(string.Join("", secondLine));
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < minLength; i++)
                {
                    if (firstLine.Length > secondLine.Length)
                    {
                        if (firstLine[i] == secondLine[i])
                        {
                            Console.WriteLine(string.Join("",secondLine));
                            Console.WriteLine(string.Join("", firstLine));
                            break;
                        }
                        else if (firstLine[i] > secondLine[i])
                        {
                            Console.WriteLine(string.Join("", secondLine));
                            Console.WriteLine(string.Join("", firstLine));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", firstLine));
                            Console.WriteLine(string.Join("", secondLine));
                            break;
                        }
                    }
                    else if(firstLine.Length < secondLine.Length)
                    {
                        if (firstLine[i] == secondLine[i])
                        {
                            Console.WriteLine(string.Join("", firstLine));
                            Console.WriteLine(string.Join("", secondLine));
                            break;
                        }
                        else if (firstLine[i] > secondLine[i])
                        {
                            Console.WriteLine(string.Join("", secondLine));
                            Console.WriteLine(string.Join("", firstLine));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", firstLine));
                            Console.WriteLine(string.Join("", secondLine));
                            break;
                        }
                    }
                }
            }
        }
    }
}
