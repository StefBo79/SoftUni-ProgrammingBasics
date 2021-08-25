using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());

            int coinsCount = 0;
            while (change > 0)
            {
            if (change >= 2.00m)
            {
                change -= 2.00m;
                coinsCount++;
            }
            else if (change >= 1.00m)
            {
                change -= 1.00m;
                coinsCount++;
            }
            else if (change >= 0.50m)
            {
                change -= 0.50m;
                coinsCount++;
            }
            else if (change >= 0.20m)
            {
                change -= 0.20m;
                coinsCount++;
            }
            else if (change >= 0.10m)
            {
                change -= 0.10m;
                coinsCount++;
            }
            else if (change >= 0.05m)
            {
                change -= 0.05m;
                coinsCount++;
            }
            else if (change >= 0.02m)
            {
                change -= 0.02m;
                coinsCount++;
            }
            else if (change >= 0.01m)
            {
                change -= 0.01m;
                coinsCount++;
            }
            }
            Console.WriteLine(coinsCount);
        }
    }
}
