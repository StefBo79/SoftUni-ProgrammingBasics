using System;

namespace ExcursionSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumSeaExcursion = int.Parse(Console.ReadLine());
            int NumMountainExcursion = int.Parse(Console.ReadLine());

            string input = string.Empty;
            const double seaPrice = 680;
            const double mountainPrice = 499;

            double profit = 0;

            while (input != "Stop")
            {
                input = Console.ReadLine();
                if (input == "sea")
                {
                    
                    if (NumSeaExcursion > 0)
                    {
                        profit += seaPrice;
                        NumSeaExcursion--;
                    }
                }
                else if (input == "mountain")
                {
                    
                    if (NumMountainExcursion > 0)
                    {
                        profit += mountainPrice;
                        NumMountainExcursion--;
                    }
                }
                if (NumSeaExcursion == 0 && NumMountainExcursion == 0)
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }
            }
            
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}

