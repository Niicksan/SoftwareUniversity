using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var star = 1;
            var roofLenght = (int)Math.Ceiling(n / 2f);

            if (n % 2 == 0)
            {
                star++;
            }

            for (int row = 1; row <= roofLenght; row++)
            {

                var pading = (n - star) / 2;

                Console.Write(new string('-', pading));
                Console.Write(new string('*', star));
                Console.Write(new string('-', pading));

                star += 2;
                Console.WriteLine();
            }

            for (int i = 0; i < (n / 2); i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}
