using System;

namespace _14._Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoatPosition = char.Parse(Console.ReadLine());
            char secondBoatPosition = char.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            int movesFirstBoat = 0;
            int movesSecondBoat = 0;

            for (int i = 1; i <= lines; i++)
            {
                string move = Console.ReadLine();

                if (i % 2 == 1)
                {
                    if (move == "UPGRADE")
                    {
                        int asciifirstBoatPosition = Convert.ToInt32(firstBoatPosition + 3);
                        firstBoatPosition = Convert.ToChar(asciifirstBoatPosition);

                        int asciisecondBoatPosition = Convert.ToInt32(secondBoatPosition + 3);
                        secondBoatPosition = Convert.ToChar(asciisecondBoatPosition);
                    }
                    else
                    {
                        movesFirstBoat += move.Length;
                        if (movesFirstBoat >= 50)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    if (move == "UPGRADE")
                    {
                        int asciifirstBoatPosition = Convert.ToInt32(firstBoatPosition + 3);
                        firstBoatPosition = Convert.ToChar(asciifirstBoatPosition);

                        int asciisecondBoatPosition = Convert.ToInt32(secondBoatPosition + 3);
                        secondBoatPosition = Convert.ToChar(asciisecondBoatPosition);
                    }
                    else
                    {
                        movesSecondBoat += move.Length;
                        if (movesSecondBoat >= 50)
                        {
                            break;
                        }
                    }
                }
            }

            if (movesFirstBoat > movesSecondBoat)
            {
                Console.WriteLine(firstBoatPosition);
            }
            else
            {
                Console.WriteLine(secondBoatPosition);
            }
        }
    }
}
