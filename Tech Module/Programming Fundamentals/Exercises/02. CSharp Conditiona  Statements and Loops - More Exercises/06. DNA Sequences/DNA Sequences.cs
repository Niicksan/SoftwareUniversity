using System;

namespace _06._DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            for (char i = 'A'; i <= 'T'; i++)
            {
                for (char j = 'A'; j <= 'T'; j++)
                {
                    for (char k = 'A'; k <= 'T'; k++)
                    {
                        if ((i == 'A' || i == 'C' || i == 'G' || i == 'T') && (j == 'A' || j == 'C' || j == 'G' || j == 'T') && (k == 'A' || k == 'C' || k == 'G' || k == 'T'))
                        {
                            if (i == 'A')
                            {
                                sum += 1;
                            }
                            else if (i == 'C')
                            {
                                sum += 2;
                            }
                            else if (i == 'G')
                            {
                                sum += 3;
                            }
                            else if (i == 'T')
                            {
                                sum += 4;
                            }

                            if (j == 'A')
                            {
                                sum += 1;
                            }
                            else if (j == 'C')
                            {
                                sum += 2;
                            }
                            else if (j == 'G')
                            {
                                sum += 3;
                            }
                            else if (j == 'T')
                            {
                                sum += 4;
                            }

                            if (k == 'A')
                            {
                                sum += 1;
                            }
                            else if (k == 'C')
                            {
                                sum += 2;
                            }
                            else if (k == 'G')
                            {
                                sum += 3;
                            }
                            else if (k == 'T')
                            {
                                sum += 4;
                            }

                            if (sum >= matchSum)
                            {
                                Console.Write($"O{i}{j}{k}O ");
                                count++;
                                sum = 0;
 
                                if (count == 4)
                                {
                                    Console.WriteLine();
                                    count = 0;
                                }
                            }
                            else
                            {
                                Console.Write($"X{i}{j}{k}X ");
                                count++;
                                sum = 0;

                                if (count == 4)
                                {
                                    Console.WriteLine();
                                    count = 0;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
