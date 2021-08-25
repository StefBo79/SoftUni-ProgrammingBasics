using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // static prices

            const double priceOfPuzzel = 2.60;
            const double priceOfTalkingDolls = 3;
            const double priceOfTeddyBear = 4.10;
            const double priceOfMinion = 8.20;
            const double priceOfTruck = 2;

            // INPUT FROM THE USER:

            double priceForVacantion = double.Parse(Console.ReadLine());
            double countOfPuzzels = double.Parse(Console.ReadLine());
            double countOfTalkingDolls = double.Parse(Console.ReadLine());
            double countOfTeddyBears = double.Parse(Console.ReadLine());
            double countOfMinions = double.Parse(Console.ReadLine());
            double countOfTrucks = double.Parse(Console.ReadLine());

            // LOGIC FOR SOLVING THE PROBLEM:

            double countOfToys = countOfPuzzels + countOfTalkingDolls + countOfTeddyBears + countOfMinions + countOfTrucks;

            double sum = countOfPuzzels * priceOfPuzzel + countOfTalkingDolls * priceOfTalkingDolls + countOfTeddyBears * priceOfTeddyBear + countOfMinions * priceOfMinion + countOfTrucks * priceOfTruck;

            // OUT OF THE RESULT AFTER SOLVING THE PROBLEM:
            double discount = 0;
            if (countOfToys >= 50) 
            {
            discount = sum * 0.25;
            }

            double finalSum = sum - discount;
            double rent = finalSum * 0.10;
            double moneyMade = finalSum - rent;

            if (priceForVacantion > moneyMade)
            {
                double moneyNeeded = priceForVacantion - moneyMade;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }
            else 
            {
                double moneyLeft = moneyMade - priceForVacantion;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
        }
    }
}