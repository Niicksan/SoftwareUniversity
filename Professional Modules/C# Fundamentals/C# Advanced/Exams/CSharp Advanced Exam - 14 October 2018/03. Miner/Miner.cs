using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Miner
{
    class Miner
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Queue<string> moves = new Queue<string>(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            char[][] jaggedArray = new char[rows][];

            int playerRow = 0;
            int playerCol = 0;

            int totalCoal = 0;
            int coal = 0;

            bool gameOver = false;


            for (int row = 0; row < jaggedArray.Length; row++)
            {
                char[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                jaggedArray[row] = new char[rows];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = input[col];

                    if (jaggedArray[row][col] == 's')
                    {
                        playerRow = row;
                        playerCol = col;
                    }

                    if (jaggedArray[row][col] == 'c')
                    {
                        totalCoal++;
                    }
                }
            }

            while (moves.Count > 0)
            {
                string currentMove = moves.Dequeue();

                if (currentMove == "up")
                {
                    if ((playerRow - 1) < 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (jaggedArray[playerRow - 1][playerCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({playerRow - 1}, {playerCol})");
                            gameOver = true;
                            break;
                        }
                        else if (jaggedArray[playerRow -1][playerCol] == 'c')
                        {
                            coal++;
                            jaggedArray[playerRow][playerCol] = '*';
                            playerRow -= 1;
                            jaggedArray[playerRow][playerCol] = 's';
                        }
                        else if (jaggedArray[playerRow - 1][playerCol] == '*')
                        {
                            jaggedArray[playerRow][playerCol] = '*';
                            playerRow -= 1;
                            jaggedArray[playerRow][playerCol] = 's';
                        }
                    }
                }
                else if (currentMove == "right")
                {
                    if ((playerCol + 1) > jaggedArray.Length - 1)
                    {
                        continue;
                    }
                    else
                    {
                        if (jaggedArray[playerRow][playerCol + 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({playerRow}, {playerCol + 1})");
                            gameOver = true;
                            continue;
                        }
                        else if (jaggedArray[playerRow][playerCol + 1] == 'c')
                        {
                            coal++;
                            jaggedArray[playerRow][playerCol] = '*';
                            playerCol += 1;
                            jaggedArray[playerRow][playerCol] = 's';
                        }
                        else if (jaggedArray[playerRow][playerCol + 1] == '*')
                        {
                            jaggedArray[playerRow][playerCol] = '*';
                            playerCol += 1;
                            jaggedArray[playerRow][playerCol] = 's';
                        }
                    }
                }
                else if (currentMove == "down")
                {
                    if ((playerRow + 1) > jaggedArray.Length - 1)
                    {
                        continue;
                    }
                    else
                    {
                        if (jaggedArray[playerRow + 1][playerCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({playerRow + 1}, {playerCol})");
                            gameOver = true;
                            break;
                        }
                        else if (jaggedArray[playerRow + 1][playerCol] == 'c')
                        {
                            coal++;
                            jaggedArray[playerRow][playerCol] = '*';
                            playerRow += 1;
                            jaggedArray[playerRow][playerCol] = 's';
                        }
                        else if (jaggedArray[playerRow + 1][playerCol] == '*')
                        {
                            jaggedArray[playerRow][playerCol] = '*';
                            playerRow += 1;
                            jaggedArray[playerRow][playerCol] = 's';
                        }
                    }
                }
                else if (currentMove == "left")
                {
                    if ((playerCol - 1) < 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (jaggedArray[playerRow][playerCol - 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({playerRow}, {playerCol - 1})");
                            gameOver = true;
                            break;
                        }
                        else if (jaggedArray[playerRow][playerCol - 1] == 'c')
                        {
                            coal++;
                            jaggedArray[playerRow][playerCol] = '*';
                            playerCol -= 1;
                            jaggedArray[playerRow][playerCol] = 's';
                        }
                        else if (jaggedArray[playerRow][playerCol - 1] == '*')
                        {
                            jaggedArray[playerRow][playerCol] = '*';
                            playerCol -= 1;
                            jaggedArray[playerRow][playerCol] = 's';
                        }
                    }
                }
            }
            if (coal == totalCoal)
            {
                Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
            }

            if (moves.Count == 0 && totalCoal > coal && gameOver == false)
            {
                Console.WriteLine($"{totalCoal - coal} coals left. ({playerRow}, {playerCol})");
            }

        }
    }
}
