using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0.0;

            while (input != "NoMoreMoney")
            {
                double moneyAdded = double.Parse(input);
                if (moneyAdded < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += moneyAdded;

                Console.WriteLine($"Increase: {moneyAdded:F2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {balance:F2}");

        }
    }
}