using System;

namespace _04._Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperial = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            double convertedValue = 0;
            string metric = "";

            switch (imperial)
            {
                case "miles":
                    metric = "kilometers";
                    convertedValue += value * 1.6;
                    break;
                case "inches":
                    metric = "centimeters";
                    convertedValue += value * 2.54;
                    break;
                case "feet":
                    metric = "centimeters";
                    convertedValue += value * 30;
                    break;
                case "yards":
                    metric = "meters";
                    convertedValue += value * 0.91;
                    break;
                case "gallons":
                    metric = "liters";
                    convertedValue += value * 3.8;
                    break;
            }

            Console.WriteLine($"{value} {imperial} = {convertedValue:F2} {metric}");
        }
    }
}
