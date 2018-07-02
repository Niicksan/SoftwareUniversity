using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int post = int.Parse(Console.ReadLine());


            for (int i = 1; i <= post; i++)
            {
                string[] element = Console.ReadLine().Split(' ');
                int price = int.Parse(element[0]);
                int termdeadline = int.Parse(element[1]);
            }
            int crash = int.Parse(Console.ReadLine());     
        }
    }
}
