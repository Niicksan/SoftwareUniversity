using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexaDecimaal = Console.ReadLine();

            int dec = Convert.ToInt16(hexaDecimaal, 16);

            Console.WriteLine(dec);
        }
    }
}
