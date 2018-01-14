using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string period = Console.ReadLine().ToLower();
            string type = Console.ReadLine().ToLower();
            string yesNo = Console.ReadLine().ToLower();
            int months = int.Parse(Console.ReadLine());

            double monthly = 0;

            if (period == "one")
            {
                if (type == "small")
                {
                    if (yesNo == "yes")
                    {
                        monthly += 9.98 + 5.50;
                    }

                    else
                    {
                        monthly += 9.98;
                    }
                }

                else if (type == "middle")
                {
                    if (yesNo == "yes")
                    {
                        monthly += 18.99 + 4.35;
                    }

                    else
                    {
                        monthly += 18.99;
                    }
                }

                else if (type == "large")
                {
                    if (yesNo == "yes")
                    {
                        monthly += 25.98 + 4.35;
                    }

                    else
                    {
                        monthly += 25.98;
                    }
                }

                else if (type == "extralarge")
                {
                    if (yesNo == "yes")
                    {
                        monthly += 35.99 + 3.85;
                    }

                    else
                    {
                        monthly += 35.99;
                    }
                }
            }

            else
            {
                if (type == "small")
                {
                    if (yesNo == "yes")
                    {
                        monthly += (8.58 + 5.50) - ((8.58 + 5.50) * 0.0375);
                    }

                    else
                    {
                        monthly += 8.58 - (8.58 * 0.0375);
                    }
                }

                else if (type == "middle")
                {
                    if (yesNo == "yes")
                    {
                        monthly += (17.09 + 4.35) - ((17.09 + 4.35) * 0.0375);
                    }

                    else
                    {
                        monthly += 17.09 - (17.09 * 0.0375);
                    }
                }

                else if (type == "large")
                {
                    if (yesNo == "yes")
                    {
                        monthly += (23.59 + 4.35) - ((23.59 + 4.35) * 0.0375);
                    }

                    else
                    {
                        monthly += 23.59 - (23.59 * 0.0375);
                    }
                }

                else if (type == "extralarge")
                {
                    if (yesNo == "yes")
                    {
                        monthly += (31.79 + 3.85) - ((31.79 + 3.85) * 0.0375);
                    }

                    else
                    {
                        monthly += 31.79 - (31.79 * 0.0375);
                    }
                }
            }

            double price = monthly * months;
            Console.WriteLine("{0:f2} lv.", price);
        }
    }
}
