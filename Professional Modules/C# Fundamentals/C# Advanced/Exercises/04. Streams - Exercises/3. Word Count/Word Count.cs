using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            string sourceFile = @"../../../../files/words.txt";
            string textSourceFile = @"../../../../files/text.txt";
            string destinationalPath = @"../../../../files/result.txt";

            using (StreamReader streamReader = new StreamReader(sourceFile))
            {
                string line = streamReader.ReadLine().ToLower();

                while (line != null)
                {
                    line = line.ToLower();

                    if (!wordCount.ContainsKey(line))
                    {
                        wordCount.Add(line, 0);
                    }

                    line = streamReader.ReadLine();
                }
            }

            using (StreamReader reader = new StreamReader(textSourceFile))
            {
                //[A-Za-z]+

                string line = reader.ReadLine().ToLower();

                while (line != null)
                {
                    line = line.ToLower();

                    Regex regex = new Regex("[A-Za-z]+");

                    foreach (Match word in regex.Matches(line))
                    {
                        if (wordCount.ContainsKey(word.Value))
                        {
                            wordCount[word.Value] += 1;
                        }
                    }

                    line = reader.ReadLine();
                }
                
            }

            using (StreamWriter streamWriter = new StreamWriter(destinationalPath))
            {
                foreach (var word in wordCount.OrderByDescending(x => x.Value))
                {
                    streamWriter.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
