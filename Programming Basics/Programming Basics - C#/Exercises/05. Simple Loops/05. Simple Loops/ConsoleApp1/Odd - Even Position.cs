using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSUm = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double min = double.MaxValue;
            double max = double.MinValue;

           // int numOnoddposition = 0;
          //  int numOnevenPosition = 0;

            for (int raw = 1; raw <= n; raw++)
            {
                double num = double.Parse(Console.ReadLine());
                if (raw % 2 == 0)
                {
                    evenSUm += num;
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }

                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }

                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }
                if (num < min)
                {
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("ODD sum = {0}", oddSum);
            Console.WriteLine("ODD Min = {0}", oddMin);
            Console.WriteLine("ODD Max = {0}", oddMax);
            Console.WriteLine("EVEN Sum = {0}", evenSUm);
            Console.WriteLine("EVEN Min = {0}", evenMin);
            Console.WriteLine("EVEN Max = {0}", evenMax);
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("<ax = {0}", max);
        }
    }
}
