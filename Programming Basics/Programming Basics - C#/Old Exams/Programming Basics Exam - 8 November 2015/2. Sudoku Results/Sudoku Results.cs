using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sudoku_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string playGames = Console.ReadLine();
            int totalSeconds = 0;
            int games = 0;
            while (playGames != "Quit")
            {
                games++;
                string[] minutesSeconds = playGames.Split(':');
                int minutes = int.Parse(minutesSeconds[0]);
                int seconds = int.Parse(minutesSeconds[1]);

                totalSeconds += minutes * 60 + seconds;

                playGames = Console.ReadLine();
            }

            double averageSeonds = (double)totalSeconds / games;
            if (averageSeonds < 720)
            {
                Console.WriteLine("Gold Star");
            }
            else if (averageSeonds >= 720 && averageSeonds <= 1440)
            {
                Console.WriteLine("Silver Star");
            }
            else
            {
                Console.WriteLine("Bronze Star");
            }
            Console.WriteLine($"Games - {games} \\ Average seconds - {Math.Ceiling(averageSeonds)}");
        }
    }
}
