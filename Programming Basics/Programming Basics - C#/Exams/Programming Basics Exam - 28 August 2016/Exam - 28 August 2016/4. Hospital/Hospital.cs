using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            double treated = 0;
            double untreated = 0;

            for (int rowPatiesnts = 1; rowPatiesnts <= days; rowPatiesnts++)
            {
                double patients = double.Parse(Console.ReadLine());

                if (rowPatiesnts % 3 == 0)
                {
                    if (untreated > treated)
                    {
                        doctors++;
                    }
                }

                if (patients <= doctors)
                {
                    treated = treated + patients;
                }

                else
                {
                    treated = treated + doctors;
                    untreated = untreated + (patients - doctors);
                }
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
