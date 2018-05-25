using System;

namespace _18._Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string m = "";

            try
            {
                sbyte sByte = sbyte.Parse(n);
                m += "* sbyte" + "\n";
            }
            catch (Exception)
            {
            }

            try
            {
                byte byteA = byte.Parse(n);
                m += "* byte" + "\n";
            }
            catch (Exception)
            {
            }

            try
            {
                short sHort = byte.Parse(n);
                m += "* short" + "\n";
            }
            catch (Exception)
            {
            }

            try
            {
                short uShort = byte.Parse(n);
                m += "* ushort" + "\n";
            }
            catch (Exception)
            {
            }
            try
            {
                short integer = byte.Parse(n);
                m += "* int" + "\n";
            }
            catch (Exception)
            {
            }
            try
            {
                short uInt = byte.Parse(n);
                m += "* uint" + "\n";
            }
            catch (Exception)
            {
            }
            try
            {
                short lonG = byte.Parse(n);
                m += "* long" + "\n";
            }
            catch (Exception)
            {
            }

            Console.WriteLine($"{n} can fit in:");
            Console.WriteLine(m);
        }
    }
}
