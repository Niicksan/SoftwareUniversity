using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = GetTrainers();
            trainers = UpdateTrainers(trainers);
            PrintTrainers(trainers);
        }

        private static void PrintTrainers(List<Trainer> trainers)
        {
            foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static List<Trainer> UpdateTrainers(List<Trainer> trainers)
        {
            string element = Console.ReadLine();

            while (element != "End")
            {
                // Update number of badges of matching trainers
                trainers
                    .Where(t => t.Pokemons.Any(p => p.Element == element))
                    .ToList()
                    .ForEach(t => t.Badges++);

                // Update pokemons of nonmatching trainers
                var nonmatchingTrainers = trainers
                                        .Where(t => t.Pokemons.All(p => p.Element != element));
                foreach (var trainer in nonmatchingTrainers)
                {
                    trainer.Pokemons.ForEach(p => p.Health -= 10);
                    trainer.Pokemons = trainer.Pokemons
                                       .Where(p => p.Health > 0)
                                       .ToList();
                }

                element = Console.ReadLine();
            }

            return trainers;
        }

        private static List<Trainer> GetTrainers()
        {
            List<Trainer> trainers = new List<Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] pokemonInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // <TrainerName> <PokemonName> <PokemonElement> <PokemonHealth>
                string trainerName = pokemonInfo[0];
                string pokemonName = pokemonInfo[1];
                string pokemonElement = pokemonInfo[2];
                int pokemonHealth = int.Parse(pokemonInfo[3]);

                Trainer trainer = trainers.FirstOrDefault(t => t.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }

                trainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));

                input = Console.ReadLine();
            }

            return trainers;
        }
    }
}
