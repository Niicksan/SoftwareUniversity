using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04._Movie_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, TimeSpan> movies = new Dictionary<string, TimeSpan>();
           
            string favoriteGenre = Console.ReadLine();
            string favoriteDuration = Console.ReadLine();

            string[] movie = Console.ReadLine().Split("|").ToArray();

            double totalDurationInSeconds = 0;

            while (movie[0] != "POPCORN!")
            {
                string title = movie[0];
                string genre = movie[1];
                string duration = movie[2];

                TimeSpan time = TimeSpan.Parse(duration, CultureInfo.InvariantCulture);
                totalDurationInSeconds += time.TotalSeconds;

                if (genre == favoriteGenre)
                {
                    if (!movies.ContainsKey(title))
                    {
                        movies.Add(title, time);
                    }
                }

                movie = Console.ReadLine().Split("|").ToArray();
            }

            movies = movies
                .OrderBy(x => favoriteDuration == "Short" ? x.Value : -x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var film in movies)
            {
                Console.WriteLine(film.Key);
                string wifeAnswer = Console.ReadLine();

                if (wifeAnswer == "Yes")
                {
                    string timeSpan = TimeSpan.FromSeconds(totalDurationInSeconds).ToString(@"hh\:mm\:ss");

                    Console.WriteLine($"We're watching {film.Key} - {film.Value}");
                    Console.WriteLine($"Total Playlist Duration: {timeSpan}");
                    return;
                }
            }
        }
    }
}