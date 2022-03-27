using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddPosition = 0;
            int evenPosition = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenPosition += number;
                }
                else
                {
                    oddPosition += number;
                }
                
            }

            if (oddPosition == evenPosition)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddPosition}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddPosition - evenPosition)}");
                Console.WriteLine("Test");
            }            
        }
    }
}
