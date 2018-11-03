using System;

namespace ClassBoxDataValidation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);

                Console.WriteLine(box.CalcullateSurfaceArea());
                Console.WriteLine(box.CalcullateLataralSurfaceArea());
                Console.WriteLine(box.CalcullateVolume());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
