using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstStars = 1;
            int centralDashes = (2 * n + 3) - 4;
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('*', firstStars));
                Console.Write(@"\");
                Console.Write(new string('-', centralDashes));
                Console.Write("/");
                Console.WriteLine(new string('*', firstStars));
                firstStars++;
                centralDashes -= 2;
            }

            int stars = n / 2;
            int centralStars = (2 * n + 3) - (2 * (n / 2) + 4);
            for (int row = 1; row <= n / 3; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', stars));
                Console.Write(@"\");
                Console.Write(new string('*', centralStars));
                Console.Write("/");
                Console.Write(new string('*', stars));
                Console.WriteLine("|");
                stars++;
                centralStars -= 2;
            }

            int firstDashes = 1;
            int centStars = (2 * n + 3) - 4;
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('-', firstDashes));
                Console.Write(@"\");
                Console.Write(new string('*', centStars));
                Console.Write("/");
                Console.WriteLine(new string('-', firstDashes));
                firstDashes++;
                centStars -= 2;
            }
        }
    }
}
