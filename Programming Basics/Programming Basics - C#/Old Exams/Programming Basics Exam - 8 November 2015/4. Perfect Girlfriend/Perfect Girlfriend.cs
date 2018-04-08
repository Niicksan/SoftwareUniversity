using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Perfect_Girlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            string girlInformation = Console.ReadLine();
            int perfectGirls = 0;

            while (girlInformation != "Enough dates!")
            {
                string[] girlInformationElement = girlInformation.Split('\\');
                string dayOfWeek = girlInformationElement[0];
                string phoneNumber = girlInformationElement[1];
                string bra = girlInformationElement[2];
                string name = girlInformationElement[3];

                int totalPoints = 0;

                //add the digit corresponding the day
                int number = 0;
                switch (dayOfWeek)
                {
                    case "Monday": number = 1; break;
                    case "Tuesday": number = 2; break;
                    case "Wednesday": number = 3; break;
                    case "Thursday": number = 4; break;
                    case "Friday": number = 5; break;
                    case "Saturday": number = 6; break;
                    case "Sunday": number = 7; break;
                }
                totalPoints += number;

                //add the sum of the digits of the phone
                for (int i = 0; i < phoneNumber.Length; i++)
                {
                    totalPoints += int.Parse(phoneNumber[i].ToString());
                }

                //exctract the bra size number and letter
                int braSize = 0;
                char braSizeLetter = bra[bra.Length - 1];

                if (bra.Length == 3)
                {
                    braSize = int.Parse(bra.Substring(0, 2));
                }
                else
                {
                    braSize = int.Parse(bra.Substring(0, 3));
                }

                //multiply the number by the ASCI code of the letter
                // and add it to the result
                totalPoints += (braSize * braSizeLetter);

                //take the first letter from the name and multiply its ASCI code by the name length
                char firstLetter = name[0];
                //substract it from the result
                totalPoints -= (firstLetter * name.Length);

                if (totalPoints >= 6000)
                {
                    Console.WriteLine($"{name} is perfect for you.");
                    perfectGirls++;
                }
                else
                {
                    Console.WriteLine($"Keep searching, {name} is not for you.");
                }
                girlInformation = Console.ReadLine();
            }
            Console.WriteLine(perfectGirls);
        }
    }
}
