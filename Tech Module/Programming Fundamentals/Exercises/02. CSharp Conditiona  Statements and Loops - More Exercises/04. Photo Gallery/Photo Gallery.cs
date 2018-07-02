using System;

namespace _04._Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictureNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string sizeConverted = "B";
            string pictureFormat = "";

            if (size >= 1000 && size < 1000000)
            {
                size /= 1000.0;
                sizeConverted = "KB";
            }
            else if (size >= 1000000)
            {
                size /= 1000000;
                sizeConverted = "MB";
            }

            if (width > height)
            {
                pictureFormat = "landscape";
            }
            else if (width < height)
            {
                pictureFormat = "portrait";
            }
            else if (width == height)
            {
                pictureFormat = "square";
            }

            Console.WriteLine($"Name: DSC_{pictureNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {size}{sizeConverted}");
            Console.WriteLine($"Resolution: {width}x{height} ({pictureFormat})");
        }
    }
}
