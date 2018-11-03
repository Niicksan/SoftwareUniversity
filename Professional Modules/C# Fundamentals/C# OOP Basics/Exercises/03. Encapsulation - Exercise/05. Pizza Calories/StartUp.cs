using System;

namespace PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var input = Console.ReadLine().Split();
                Pizza pizza = new Pizza(input[1]);
                input = Console.ReadLine().Split();
                pizza.Dough = new Dough(input[1], input[2], int.Parse(input[3]));

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    input = command.Split();
                    pizza.AddTopping(new Topping(input[1], int.Parse(input[2])));
                }

                Console.WriteLine(pizza);
            }
            catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        }
    }
}
