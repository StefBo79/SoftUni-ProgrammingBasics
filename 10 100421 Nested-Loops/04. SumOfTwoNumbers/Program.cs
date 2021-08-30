using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int begining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isFound = false;

            for (int x = begining; x <= end; x++)
            {
                for (int y = begining; y <= end; y++)
                {
                    combinations++;
                    if (x + y == magicNumber)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{combinations} ({x} + {y} = {magicNumber})");
                        return;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
