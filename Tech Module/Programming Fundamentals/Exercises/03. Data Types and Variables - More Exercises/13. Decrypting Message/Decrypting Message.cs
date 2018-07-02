using System;

namespace _13._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLetters = int.Parse(Console.ReadLine());

            string message = "";

            for (int i = 1; i <= numberOfLetters; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                letter += (char)key;
                message += letter;
            }

            Console.WriteLine(message);
        }
    }
}
