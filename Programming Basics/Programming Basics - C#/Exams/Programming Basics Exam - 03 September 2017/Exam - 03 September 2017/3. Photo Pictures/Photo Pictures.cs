using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int photos = int.Parse(Console.ReadLine());
            string size = Console.ReadLine().ToLower();
            string onlineOfline = Console.ReadLine();

            double price = 0;
            double discaunt = 1;
            if (size == "9x13")
            {
                price = 0.16;

                if (photos >= 50)
                {
                    discaunt = 0.95;
                }
            }
            else if (size == "10x15")
            {
                price = 0.16;

                if (photos >= 80)
                {
                    discaunt = 0.97;
                }
            }

            else if (size == "13x18")
            {
                price = 0.38;

                if (photos >= 50 && photos <= 100)
                {
                    discaunt = 0.97;
                }

                else
                {
                    discaunt = 0.95;
                }
            }

            else
            {
                price = 2.90;

                if (photos >= 10 && photos <= 50)
                {
                    discaunt = 0.93;
                }

                else
                {
                    discaunt = 0.91;
                }
            }

            double sum = photos * price * discaunt;

            if (onlineOfline == "online")
            {
                sum *= 0.98;
            }

            Console.WriteLine("{0:f2}BGN", sum);
        }
    }
}
