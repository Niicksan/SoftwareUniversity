using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Wrong_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,,] cube = new int[size, size, size];

            for (int h = 0; h < size; h++)
            {
                string[] number = Console.ReadLine().Replace(" ", "").Split('|');
                for (int d = 0; d < size; d++)
                {
                    for (int w = 0; w < size; w++)
                    {
                        cube[w, h, d] = 
                    }
                }
            }
        }
    }
}
