using System;

namespace _02._Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();

            double spent = 0;
            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        if (balance >= 39.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            balance -= 39.99;
                            spent += 39.99;

                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                            }
                        }
                        else if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (balance >= 15.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            balance -= 15.99;
                            spent += 15.99;

                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                            }
                        }
                        else if (balance < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (balance >= 19.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            balance -= 19.99;
                            spent += 19.99;

                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                            }
                        }
                        else if (balance < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (balance >= 59.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            balance -= 59.99;
                            spent += 59.99;

                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                            }
                        }
                        else if (balance < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (balance >= 29.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            balance -= 29.99;
                            spent += 29.99;

                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                            }
                        }
                        else if (balance < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance >= 39.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            balance -= 39.99;
                            spent += 39.99;

                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                            }
                        }
                        else if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                game = Console.ReadLine();
            }

            if (balance > 0)
            {
                Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${balance:F2}");
            }            
        }
    }
}
