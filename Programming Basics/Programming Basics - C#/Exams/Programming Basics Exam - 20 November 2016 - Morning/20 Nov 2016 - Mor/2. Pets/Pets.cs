using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dog = double.Parse(Console.ReadLine());
            double cat = double.Parse(Console.ReadLine());
            double turtle = double.Parse(Console.ReadLine());

            double foodDog = days * dog;
            double foodCat = days * cat;
            double foodTurtle = days * turtle / 1000;

            double foodEaten = foodDog + foodCat + foodTurtle;
            double foodLeft = Math.Abs(food - foodEaten);

            if (foodEaten <= food)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodLeft));
            }

            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(foodLeft));
            }
        }
    }
}
