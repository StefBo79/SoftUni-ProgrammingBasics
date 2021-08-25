using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                //char letter = input[1]; или това или долното директно.
                Console.WriteLine(input[i]);
            }
        }
    }
}