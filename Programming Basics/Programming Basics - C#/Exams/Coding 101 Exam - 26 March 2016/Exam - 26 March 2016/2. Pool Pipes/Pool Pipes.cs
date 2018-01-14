using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Pool_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double P1 = double.Parse(Console.ReadLine());
            double P2 = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double pipe1 = P1 * H;
            double pipe2 = P2 * H;
            double fulllevel = pipe1 + pipe2;
            double pipe1Level = Math.Floor((pipe1 / fulllevel) * 100);
            double pipe2Level = Math.Floor((pipe2 / fulllevel) * 100);
            double fullLevel = Math.Floor((fulllevel / V) * 100);
            double overflow = fulllevel - V;

            if (fulllevel > V)
            {
                Console.WriteLine(
                    $"For {H} hours the pool overflows with {string.Format("{0:f1}", overflow)} liters.");
            }

            else
            {
                Console.WriteLine(
                $"The pool is {fullLevel}% full. Pipe 1: {pipe1Level}%. Pipe 2: {pipe2Level}%.");
            }
        }
    }
}
