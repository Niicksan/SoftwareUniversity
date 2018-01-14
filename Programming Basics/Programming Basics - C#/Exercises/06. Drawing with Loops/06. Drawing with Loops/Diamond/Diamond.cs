using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows;
            int leftToRight = 0;
            int starEdge;
            int mid = 0;

            //Here we check if the count of n is even or odd. The first values of some variables, which we will use
            // depend on the result of this check.
            if (n % 2 == 0)
            {
                rows = n - 1;
                starEdge = 2;
                mid = 2;
            }
            else
            {
                rows = n;
                starEdge = 1;
                mid = 1;
            }

            //First, we check if n equals 1 or 2, because these are special cases
            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else if (n == 2)
            {
                Console.WriteLine("**");
            }
            else
            {
                //Here, we have a loop for the first part of the diamond -> For the first (n-1)/2 rows.
                for (int row = 1; row <= (rows + 1) / 2; row++)
                {
                    //The first row and the others have different count of the two types of signs
                    if (row == 1)
                    {
                        leftToRight = (n - 1) / 2;
                        Console.Write(new string('-', leftToRight));
                        Console.Write(new string('*', starEdge));
                        Console.Write(new string('-', leftToRight));
                    }
                    //Here, we have dashes between the stars/the two stars. This is dfference between the 1st and 
                    //other rows.
                    else
                    {
                        Console.Write(new string('-', leftToRight));
                        Console.Write("*");
                        Console.Write(new string('-', mid));
                        Console.Write("*");
                        Console.Write(new string('-', leftToRight));
                        mid += 2;
                    }
                    Console.WriteLine();
                    leftToRight--;
                }

                //Change the values for this variables,because we want to print all, but last row from the first
                //part of the diamond in opposite order.
                mid -= 4;
                leftToRight = 1;

                //Almost the same code as the first part.
                for (int row = ((rows + 1) / 2) + 1; row <= rows; row++)
                {
                    if (row == rows)
                    {
                        //leftToRight = (n - 1) / 2;
                        Console.Write(new string('-', leftToRight));
                        Console.Write(new string('*', starEdge));
                        Console.Write(new string('-', leftToRight));
                    }
                    else
                    {
                        Console.Write(new string('-', leftToRight));
                        Console.Write("*");
                        Console.Write(new string('-', mid));
                        Console.Write("*");
                        Console.Write(new string('-', leftToRight));
                        mid -= 2;
                    }
                    Console.WriteLine();
                    leftToRight++;
                }
            }
        }
    }
}
