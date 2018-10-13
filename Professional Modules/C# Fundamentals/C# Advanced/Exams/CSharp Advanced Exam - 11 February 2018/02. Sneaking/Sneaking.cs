using System;
using System.Linq;

namespace _02._Sneaking
{
    class Sneaking
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] room = new char[rows][];

            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < room.Length; row++)
            {
                string currentRow = Console.ReadLine();

                room[row] = new char[currentRow.Length];

                for (int col = 0; col < room[row].Length; col++)
                {
                    room[row][col] = currentRow[col];

                    if (room[row][col] == 'S')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }

                //if (room[row].Contains('b') && Array.IndexOf(room[row], 'b') < playerCol)
                //{
                //    room[playerRow][playerCol] = 'X';
                //    Console.WriteLine($"Sam died at {playerRow}, {playerCol}");
                //    break;
                //}
                //else if (room[row].Contains('d') && Array.IndexOf(room[row], 'd') > playerCol)
                //{
                //    room[playerRow][playerCol] = 'X';
                //    Console.WriteLine($"Sam died at {playerRow}, {playerCol}");
                //    break;
                //}
            }

            char[] directions = Console.ReadLine().ToCharArray();

            bool[] winLose = new bool[2];

            for (int i = 0; i < directions.Length; i++)
            {
                MoveEnemies(room);

                if (room[playerRow].Contains('d') && Array.IndexOf(room[playerRow], 'd') > playerCol)
                {
                    room[playerRow][playerCol] = 'X';
                    Console.WriteLine($"Sam died at {playerRow}, {playerCol}");
                    break;
                }
                else if (room[playerRow].Contains('b') && Array.IndexOf(room[playerRow], 'b') < playerCol)
                {
                    room[playerRow][playerCol] = 'X';
                    Console.WriteLine($"Sam died at {playerRow}, {playerCol}");
                    break;
                }
               
                MoveSam(room, ref playerRow, ref playerCol, directions[i]);

                if (room[playerRow].Contains('N'))
                {
                    int colOfN = Array.IndexOf(room[playerRow], 'N');
                    room[playerRow][colOfN] = 'X';
                    Console.WriteLine("Nikoladze killed!");
                    break;
                }
            }

            foreach (var row in room)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void MoveSam(char[][] room, ref int playerRow, ref int playerCol, char direction)
        {
            room[playerRow][playerCol] = '.';

            switch (direction)
            {
                case 'U':
                    playerRow--;
                    break;
                case 'D':
                    playerRow++;
                    break;
                case 'L':
                    playerCol--;
                    break;
                case 'R':
                    playerCol++;
                    break;
                default:
                    break;
            }

            room[playerRow][playerCol] = 'S';
        }

        private static void MoveEnemies(char[][] room)
        {
            for (int row = 0; row < room.Length; row++)
            {
                int indexD = Array.IndexOf(room[row], 'd');
                int indexB = Array.IndexOf(room[row], 'b');

                if (indexD != -1)
                {
                    if (indexD == 0)
                    {
                        room[row][indexD] = 'b';
                    }
                    else
                    {
                        room[row][indexD] = '.';
                        indexD--;
                        room[row][indexD] = 'd';
                    }
                }
                else if (indexB != -1)
                {
                    if (indexB == room[row].Length - 1)
                    {
                        room[row][indexB] = 'd';
                    }
                    else
                    {
                        room[row][indexB] = '.';
                        indexB++;
                        room[row][indexB] = 'b';
                    }
                }
            }
        }
    }
}