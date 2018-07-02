using System;

namespace _15._Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int healthPesho = 100;
            int healthGosho = 100;

            string attacker = "";
            string attack = "";
            string defender = "";
            int healthLeft = 0;
            int round = 0;
            while (healthGosho > 0 && healthPesho > 0)
            {
                round++;
                if (round % 2 == 1)
                {
                    attacker = "Pesho";
                    attack = "Roundhouse kick";
                    defender = "Gosho";
                    healthGosho -= damagePesho;
                    healthLeft = healthGosho;
                }
                else
                {
                    attacker = "Gosho";
                    attack = "Thunderous fist";
                    defender = "Pesho";
                    healthPesho -= damageGosho;
                    healthLeft = healthPesho;
                }


                if (healthPesho <= 0 || healthGosho <= 0)
                {
                    break;
                }

                Console.WriteLine($"{attacker} used {attack} and reduced {defender} to {healthLeft} health.");

                if (round % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
            }

            if (healthGosho <= 0)
            {
                Console.WriteLine($"Pesho won in {round}th round.");
            }
            else if (healthPesho <= 0)
            {
                Console.WriteLine($"Gosho won in {round}th round.");
            }
        }
    }
}
