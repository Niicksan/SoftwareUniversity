﻿using System;

namespace ClassBox
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);

            box.CalcullateSurfaceArea();
            box.CalcullateLataralSurfaceArea();
            box.CalcullateVolume();
        }
    }
}
