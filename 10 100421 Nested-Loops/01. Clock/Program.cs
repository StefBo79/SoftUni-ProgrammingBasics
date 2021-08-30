using System;

namespace Nested_Loops_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h <= 23; h++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    for (int s = 0; s <= 59; s++)
                    {
                        Console.WriteLine($"{h:D2}:{m:D2}:{s:D2}");
                    }
                }
            }
        }
    }
}
