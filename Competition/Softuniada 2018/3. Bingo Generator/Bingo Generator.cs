using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Bingo_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int dig4 = number % 10;
            number /= 10;

            int dig3 = number % 10;
            number /= 10;

            int dig2 = number % 10;

            int dig1 = number / 10;

            int countTwelve = 0;
            int countFifteen = 0;

            int firstNewNumber = (dig1 * 10) + dig3;
            int secondNewNumber = (dig2 * 10) + dig4;

            int roof = firstNewNumber + secondNewNumber;
            int newNumber = firstNewNumber * 100 + secondNewNumber;

            string dividingOnTwelve = "";
            string dividingOnFifteen = "";
            for (int row = firstNewNumber; row <= roof; row++)
            {
                for (int col = secondNewNumber; col <= roof; col++)
                {
                    int newFourDigNumber = row * 100 + col;
                    if (newFourDigNumber % 12 == 0)
                    {
                        dividingOnTwelve += newFourDigNumber + " ";
                        countTwelve++;
                    }
                    if (newFourDigNumber % 15 == 0)
                    {
                        dividingOnFifteen += newFourDigNumber + " ";
                        countFifteen++;
                    }
                }
            }

            Console.WriteLine("Dividing on 12: " + dividingOnTwelve);
            Console.WriteLine("Dividing on 15: " + dividingOnFifteen);

            if (countTwelve == countFifteen)
            {
                Console.WriteLine("!!!BINGO!!!");
            }
            else
            {
                Console.WriteLine("NO BINGO!");
            }
        }
    }
}
