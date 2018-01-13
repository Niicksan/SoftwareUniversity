using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass = (Console.ReadLine());
            var password = "s3cr3t!P@ssw0rd";

            if (pass == password)
            {
                Console.WriteLine("Wellcome");
            }

            else
	        {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
