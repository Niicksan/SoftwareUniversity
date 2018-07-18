﻿using System;

namespace _05._BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int BPM = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());
            Console.Write($"{Math.Round(beats / 4.0, 1) } ");
            double seconds = beats * 60.0 / BPM;
            int minutes = (int)seconds / 60;
            seconds -= minutes * 60;
            Console.WriteLine($"bars - {minutes}m {Math.Floor(seconds)}s");
        }
    }
}