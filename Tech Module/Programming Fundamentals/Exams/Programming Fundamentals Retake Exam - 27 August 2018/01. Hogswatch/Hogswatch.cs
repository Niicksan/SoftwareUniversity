using System;

namespace _01._Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int presents = int.Parse(Console.ReadLine());

            int homevisited = 0;
            
            int presentToHave = 0;
            int totalPresent = 0;
            int presentsLeft = presents;
            int goBack = 0;

            for (int i = 1; i <= n; i++)
            {
                int children = int.Parse(Console.ReadLine());

                homevisited++;
                int homeremaining = n - homevisited;

                if (children <= presentsLeft)
                {
                    presentsLeft -= children;
                }
                else
                {
                    goBack++;
                    presentToHave = (presents / homevisited) * homeremaining + (children - presentsLeft);
                    presentsLeft += presentToHave;
                    totalPresent += presentToHave;
                    presentsLeft -= children;
                }

            }

            if (goBack == 0)
            {
                Console.WriteLine(presentsLeft);
            }
            else
            {
                Console.WriteLine(goBack);
                Console.WriteLine(totalPresent);
            }
        }
    }
}
