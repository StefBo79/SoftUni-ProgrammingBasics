
using System;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "ACTION")
            {
                double salary = 0;
                if (input.Length <= 15)
                {
                    salary = double.Parse(Console.ReadLine());
                }
                else
                {
                    salary = budget * 0.20;
                }
                budget -= salary;

                if (budget <= 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
                    break;
                }

                input = Console.ReadLine();
            }
            if (budget > 0)
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
        }
    }
}