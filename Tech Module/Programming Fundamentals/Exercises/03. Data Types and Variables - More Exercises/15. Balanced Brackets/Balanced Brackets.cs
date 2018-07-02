using System;

namespace _15._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int open = 0;      // OPENING BRACKETS
            int closed = 0;    // CLOSING BRACKETS

            bool balanced = true;

            for (int i = 1; i <= n; i++)
            {
                string line = Console.ReadLine();


                if (line == "(")
                {
                    open++;
                }
                else if (line == ")")
                {
                    if (open == 0)
                    {
                        balanced = false; // no opening bracket before closing bracket
                    }
                    else
                    {
                        closed++;
                    }
                }

                if (open == 1 && closed == 1) // RESET
                {
                    open--;
                    closed--;
                }
            }

            if (open == closed && balanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
