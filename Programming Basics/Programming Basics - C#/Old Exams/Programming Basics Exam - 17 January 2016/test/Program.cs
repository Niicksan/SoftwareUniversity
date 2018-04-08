using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////   Test 1    \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            //  /* Test 1                                                                                                                             \\
            //   input:                                                                                                                               \\
            //   int number = int.Parse(Console.ReadLine()); // Взимаме максималната стойност на ulong                                                \\
            //   int position = int.Parse(Console.ReadLine());                                                                                        \\
            //   string binary = Convert.ToString((int)number, 2); // Конвертираме го в двоична бройна система                                        \\
            //   string binary32 = Convert.ToString((int)number, 2).PadLeft(32,'0'); // Конвертираме го в двоична бройна система всичките 32 бита     \\
            //   int converted = Convert.ToInt32(binary32, 2); // Конвертираме двоичното число отново към ulong за проверка                           \\
            //                                                                                                                                        \\
            //   //Console.WriteLine(binary); // Двоично представяне                                                                                  \\       
            //     Console.WriteLine(binary32); // Двоично представяне на всичките 32 бита                                                            \\
            //     int mask = 1 << position;                                                                                                          \\
            //     int bitAtPosition = number & mask;                                                                                                 \\
            //     string newBinary = Convert.ToString((int)bitAtPosition, 2).PadLeft(32, '0');                                                       \\
            //     int newConverted = Convert.ToInt32(newBinary, 2);                                                                                  \\
            //                                                                                                                                        \\
            //     Console.WriteLine(bitAtPosition); // Новото число след shift-ването                                                                \\
            //   //Console.WriteLine(newBinary); // Двоично представяне след shift-ването                                                             \\       
            //     Console.WriteLine(newBinary); // Двоично представяне на всичките 32 бита след shift-ването                                         \\
            //     Console.WriteLine(converted); // Конвертираният към ulong string                                                                   \\
            //     Console.WriteLine(converted); // Конвертираният към ulong string                                                                   \\
            //     Console.WriteLine(newConverted == bitAtPosition); // Сравняваме първоначалното и крайното число                                    \\
            //     goto input; */                                                                                                                     \\
            //                                                                                                                                        \\
            ///////////////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


            /////////////////////////////////////////////////////////////   Test 2    \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            //   /* Test 2
            //   input:
            //   int number = int.Parse(Console.ReadLine()); // 35 >> 00000000 00100011
            //   int position = int.Parse(Console.ReadLine());
            //   string binary = Convert.ToString((int)number, 2).PadLeft(32,'0'); // Конвертираме го в двоична бройна система всичките 32 бита
            //   int mask = ~(1 << position);                         // 00000000 00010000
            //   int bitAtPosition = number & mask;                // 00000000 00010000
            //
            //   string maskBinary = Convert.ToString((int)mask, 2).PadLeft(32, '0');
            //   string bitAtPositionBinary = Convert.ToString((int)bitAtPosition, 2).PadLeft(32, '0');
            //
            //   int bitValueOne = 1; // 0001
            //   int bitValueZero = 0; // 0000
            //
            //   bitValueOne = bitValueOne << 3; //1000
            //   bitAtPosition = bitAtPosition | bitValueOne; //1011
            //
            //   Console.WriteLine(binary);
            //   Console.WriteLine(maskBinary);
            //   Console.WriteLine(bitAtPositionBinary);
            //   Console.WriteLine();
            //   string bitValue = Convert.ToString((int)bitValueOne, 2).PadLeft(32, '0');
            //   string newBitPositionBinary = Convert.ToString((int)bitAtPosition, 2).PadLeft(32, '0');
            //   Console.WriteLine(bitAtPositionBinary);
            //   Console.WriteLine(bitValue);
            //   Console.WriteLine(newBitPositionBinary);
            //   goto input; */
            //
            /////////////////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\







            /////////////////////////////////////////////////////////////   Test 3    \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            /* Test 3
               input:
               int number = int.Parse(Console.ReadLine()); // 39 >> 100111
               int closePosition = int.Parse(Console.ReadLine());
               int farPosition = int.Parse(Console.ReadLine());

               int maskClose = 1 << closePosition; // 1000
               int closeBitValue = number & maskClose; //000000

               int maskFar = 1 << farPosition; // 100000;
               int farBitValue = number & maskFar; //000 100000;

               string numberBinary = Convert.ToString((int)number, 2).PadLeft(32, '0');
               string maskCloseBinary = Convert.ToString((int)maskClose, 2).PadLeft(32, '0');
               string closeBitValueBinary = Convert.ToString((int)closeBitValue, 2).PadLeft(32, '0');

               string maskFaBinary = Convert.ToString((int)maskFar, 2).PadLeft(32, '0');
               string farBitValueBinary = Convert.ToString((int)farBitValue, 2).PadLeft(32, '0');

               Console.WriteLine("Close Bit");
               Console.WriteLine(numberBinary);
               Console.WriteLine(maskCloseBinary);
               Console.WriteLine(closeBitValueBinary);
               Console.WriteLine();

               Console.WriteLine("Far Bit");
               Console.WriteLine(numberBinary);
               Console.WriteLine(maskFaBinary);
               Console.WriteLine(farBitValueBinary);
               Console.WriteLine();

               closeBitValue = closeBitValue >> closePosition;
               farBitValue = farBitValue >> farPosition; // 000001

               maskFaBinary = Convert.ToString((int)maskFar, 2).PadLeft(32, '0');
               farBitValueBinary = Convert.ToString((int)farBitValue, 2).PadLeft(32, '0');

               Console.WriteLine("Return the bit on first position");
               Console.WriteLine(closeBitValueBinary);
               Console.WriteLine(farBitValueBinary); 
               Console.WriteLine();

               int invertedMaskClose = ~maskClose; // 11110111
               int newNumber = number & invertedMaskClose; // 100111 

               string invertedMaskCloseBinary = Convert.ToString((int)invertedMaskClose, 2).PadLeft(32, '0');
               string newNumberBinary = Convert.ToString((int)newNumber, 2).PadLeft(32, '0');

               Console.WriteLine(maskCloseBinary + " Mask Close"); // 1000
               Console.WriteLine(invertedMaskCloseBinary + " Inverted Mask"); // 11110111
               Console.WriteLine(numberBinary + " Number"); // 100111
               Console.WriteLine(newNumberBinary); // 100111
               Console.WriteLine();

               int invertedMaskFar = ~maskFar; // 111011111
               int newNewNumber = newNumber & invertedMaskFar; // 000111

               string invertedMaskFarBinary = Convert.ToString((int)invertedMaskFar, 2).PadLeft(32, '0');
               string newNewNumberBinary = Convert.ToString((int)newNewNumber, 2).PadLeft(32, '0');

               Console.WriteLine(maskFaBinary + " Mask Far"); // 100000
               Console.WriteLine(invertedMaskFarBinary + " Inverted Mask"); // 111011111
               Console.WriteLine(newNumberBinary + " Number"); // 100111
               Console.WriteLine(newNewNumberBinary); // 000111
               Console.WriteLine();

               closeBitValue = closeBitValue << farPosition; //000000
               number = number | closeBitValue; // тук влияем на 5тия бит вече !!!! //000111
               farBitValue = farBitValue << closePosition; // 1000
               number = number | farBitValue; //00010111

               numberBinary = Convert.ToString((int)number, 2).PadLeft(32, '0');
               Console.WriteLine(numberBinary);

               goto input; */

            /////////////////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\




            ////////////////////////////////////////////////////////   5.Salt and Papper    \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            /* 5.Salt and Papper
            ulong number = ulong.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandElement = command.Split(' ');
                string action = commandElement[0];
                int step = int.Parse(commandElement[1]);

                if (action == "salt")
                {
                    for (int i = 0; i <= 63; i += step)
                    {
                        if (((number >> i) & 1) == 1)
                        {
                            ulong mask = ~((ulong)1 << i);
                            number = number & mask;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= 63; i += step)
                    {
                        if (((number >> i) & 1) == 0)
                        {
                            ulong mask = (ulong)1 << i;
                            number = number | mask;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(number); 
                * /
            
            /////////////////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\






            /////////////////////////////////////////////////////   5.Emergency Repairs - Test   \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            /* 5.Emergency Repairs
            ulong wall = ulong.Parse(Console.ReadLine());
            int emergencyKits = int.Parse(Console.ReadLine());
            int attacks = int.Parse(Console.ReadLine());

            string wallBinary = Convert.ToString((int)wall, 2).PadLeft(32, '0');
            Console.WriteLine();
            Console.WriteLine(wallBinary);

            for (uint i = 1; i <= attacks; i++)
            {
                int attackedBit = int.Parse(Console.ReadLine());
                wall = wall & ~((ulong)1 << attackedBit);

                wallBinary = Convert.ToString((int)wall, 2).PadLeft(32, '0');

                Console.WriteLine();
                Console.WriteLine(wallBinary);
                Console.WriteLine();
            } */

            /////////////////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\




            //////////////////////////////////////////////////////////    4.Passion Days    \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            /*
            decimal money = decimal.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int purchases = 0;

            while (command != "mall.Enter")
            {
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "mall.Exit")
            {
                string actions = command;
                for (int i = 0; i < actions.Length; i++)
                {
                    decimal price = 0;
                    if (actions[i] >= 65 && actions[i] <= 90)
                    {
                        price = actions[i] * 0.5m;
                        if (money < price)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                    }
                    else if (actions[i] >= 97 && actions[i] <= 122)
                    {
                        price = actions[i] * 0.3m;
                        if (money < price)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                    }
                    else if (actions[i] == '%')
                    {
                        
                        if (money > 0)
                        {
                            money /= 2;
                            purchases++;
                        }
                    }
                    else if (actions[i] == '*')
                    {
                        money += 10;
                    }
                    else
                    {
                        price = actions[i];
                        if (money < price)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                    }
                }
                command = Console.ReadLine();
            }

            if (purchases == 0)
            {
                Console.WriteLine($"No purchases. Money left: {money:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{purchases:f2} purchases. Money left: {money:f2} lv.");
            } */


            /////////////////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\






            /////////////////////////////////////////////////////////    4.Master Herbalist    \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            /*
            int dailyExpenses = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int totalMoney = 0;
            int days = 0;

            while (line != "Season Over")
            {
                days++;
                string[] lineElement = line.Split(' ');
                int hours = int.Parse(lineElement[0]);
                string path = lineElement[1];
                int moneyPerHerb = int.Parse(lineElement[2]);
                int herbs = 0;

                for (int i = 0; i < hours; i++)
                {
                    if (path[i % path.Length] == 'H')
                    {
                        herbs++;
                    }
                }
                totalMoney = herbs * moneyPerHerb;
                line = Console.ReadLine();
            }

            decimal moneyPerDay = (decimal)totalMoney / days;
            decimal extraMoney = moneyPerDay - dailyExpenses;
            decimal moreMoneyNeeded = (days * dailyExpenses) - totalMoney;
            if (moneyPerDay >= dailyExpenses)
            {
                Console.WriteLine($"Times are good. Extra money per day: {extraMoney:f2}.");
            }
            else
            {

                Console.WriteLine($"We are in the red. Money needed: {moreMoneyNeeded}.");
            }*/


            /////////////////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\








            ulong wall = ulong.Parse(Console.ReadLine());
            int emergencyKits = int.Parse(Console.ReadLine());
            int attacks = int.Parse(Console.ReadLine());

            for (int i = 0; i < attacks; i++)
            {
                int attackedBit = int.Parse(Console.ReadLine());
                wall = wall & ~((ulong)1 << attackedBit);
            }

            for (int i = 0; i < 64; i++)
            {
                ulong bit = (wall >> i) & 1;
                if (bit == 0 && emergencyKits > 0)
                {
                    bool foundHole = false;
                    while (emergencyKits > 0 && i + 1 < 64 && ((wall >> (i + 1) & 1) == 0));
                    {
                        wall = wall | ((ulong)1 << i);
                        i++;
                        emergencyKits--;
                        foundHole = true;
                    }
                    if (foundHole && emergencyKits > 0)
                    {
                        wall = wall | ((ulong)1 << 1);
                    }
                }
            }
            Console.WriteLine(wall);
        }
    }
}
