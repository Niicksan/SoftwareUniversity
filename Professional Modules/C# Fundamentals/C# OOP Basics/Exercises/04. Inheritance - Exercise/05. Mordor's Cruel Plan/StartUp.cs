using System;

namespace CruelPlan
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] foods = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Gandalf gandalf = new Gandalf();

            foreach (var food in foods)
            {
                gandalf.EatFood(food);
            }

            Console.WriteLine(gandalf.HappinesPoints);
            Console.WriteLine(gandalf.Mood());
        }
    }
}
