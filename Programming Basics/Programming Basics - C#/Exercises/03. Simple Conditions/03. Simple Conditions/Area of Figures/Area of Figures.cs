using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine().ToLower();

            if (figure == "square")
            {
                var asquare = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(asquare * asquare, 3));
            }

            else if (figure == "rectangle")
            {
                var arectangle = double.Parse(Console.ReadLine());
                var brectangle = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(arectangle * brectangle, 3));
            }

            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * r * r, 3));
            }

            else if (figure == "triangle")
            {
                var atriangle = double.Parse(Console.ReadLine());
                var htriangle = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(atriangle * htriangle / 2, 3));
            }
        }
    }
}
