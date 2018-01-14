using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string types = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int full = rows * columns;
            double income = -1;

            switch (types)
            {
                case "premiere":
                    income = full * 12.00;
                    break;
                case "normal":
                    income = full * 7.50;
                    break;
                case "discount":
                    income = full * 5.00;
                    break;
                default:
                    break;
            }

            Console.WriteLine(Math.Round(income, 2) + " leva");
        }
    }
}
