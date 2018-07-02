using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Stars_in_the_Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the cube
            int n = int.Parse(Console.ReadLine());
            char[,,] cube = new char[n, n, n];

            for (int h = 0; h < n; h++)
            {
                string[] letters = Console.ReadLine().Replace(" ", "").Split('|');
                for (int d = 0; d < n; d++)
                {
                    for (int w = 0; w < n; w++)
                    {
                        cube[w, h, d] = letters[d][w];
                    }
                }
            }

            // Find all 7-cell 3D stars in the cube
            int starsCount = 0;
            char[] starsCountByLetter = new char['z' -'a' + 1];
            for (int w = 1; w < n - 1; w++)
            {
                for (int h = 1; h < n - 1; h++)
                {
                    for (int d = 1; d < n - 1; d++)
                    {
                        char letter = cube[w, h, d];
                        bool sameLetter =
                            (cube[w + 1, h, d] == letter) &&
                            (cube[w - 1, h, d] == letter) &&
                            (cube[w, h + 1, d] == letter) &&
                            (cube[w, h - 1, d] == letter) &&
                            (cube[w, h, d + 1] == letter) &&
                            (cube[w, h, d - 1] == letter);
                        if (sameLetter)
                        {
                            starsCount++;
                            starsCountByLetter[letter - 'a']++;
                        }
                    }
                }
            }

            // Print the result
            Console.WriteLine(starsCount);
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                int count = starsCountByLetter[letter - 'a'];
                if (count > 0)
                {
                    Console.WriteLine($"{letter} -> {count}");
                }
            }
        }
    }
}
