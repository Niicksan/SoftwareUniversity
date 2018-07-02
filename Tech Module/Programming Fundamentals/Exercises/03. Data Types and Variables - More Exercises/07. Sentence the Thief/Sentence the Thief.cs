using System;

namespace _07._Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int numberIDs = int.Parse(Console.ReadLine());

            long thiefsID = 0;
            long minValue = 0;
            double sentence = 0;

            if (type == "sbyte")
            {
                minValue = sbyte.MinValue;
                for (int i = 1; i <= numberIDs; i++)
                {
                    long id = long.Parse(Console.ReadLine());

                    if (id >= minValue && id <= sbyte.MaxValue)
                    {
                        minValue = id;
                        thiefsID = minValue;
                    }
                }
            }
            else if (type == "int")
            {
                minValue = int.MinValue;
                for (int i = 1; i <= numberIDs; i++)
                {
                    long id = long.Parse(Console.ReadLine());

                    if (id >= minValue && id <= int.MaxValue)
                    {
                        minValue = id;
                        thiefsID = minValue;
                    }
                }
            }
            else if (type == "long")
            {
                minValue = long.MinValue;
                for (int i = 1; i <= numberIDs; i++)
                {
                    long id = long.Parse(Console.ReadLine());

                    if (id >= minValue && id <= long.MaxValue)
                    {
                        minValue = id;
                        thiefsID = minValue;
                    }
                }
            }

            if (thiefsID < 0)
            {
                sentence = Math.Ceiling((double)(thiefsID / -128.0));
            }
            else
            {
                sentence = Math.Ceiling((double)(thiefsID / 127.0));
            }

            if (sentence == 1)
            {
                Console.WriteLine($"Prisoner with id {thiefsID} is sentenced to {sentence} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefsID} is sentenced to {sentence} years");
            }
        }
    }
}
