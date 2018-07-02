using System;

namespace _01._Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long percentage = long.Parse(Console.ReadLine());
            long timeForPicture = long.Parse(Console.ReadLine());

            long filteredPictures = (long)Math.Ceiling(pictures * (percentage / 100.0));
            long filtered = pictures * filterTime;
            long totalTime = filtered + (filteredPictures * timeForPicture);

            long days = totalTime / 86400;
            totalTime %= 86400;
            long hours = totalTime / 3600;
            totalTime %= 3600;
            long minutes = totalTime / 60;
            totalTime %= 60;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{totalTime:D2}");
        }
    }
}