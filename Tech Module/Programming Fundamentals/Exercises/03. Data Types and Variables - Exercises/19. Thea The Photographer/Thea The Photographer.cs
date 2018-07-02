using System;

namespace _19._Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long goodPictures = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long totalFilterTime = pictures * filterTime;
            decimal totalUploadTime = (Math.Ceiling(pictures * (goodPictures / 100.0m))) * uploadTime;

            long totalTime = totalFilterTime + (long)totalUploadTime;

            long days = totalTime / 86400;
            totalTime %=  86400;
            long hours = totalTime / 3600;
            totalTime %= 3600;
            long minutes = totalTime / 60;
            long seconds = totalTime % 60;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:d2}:{seconds:D2}");
        }
    }
}