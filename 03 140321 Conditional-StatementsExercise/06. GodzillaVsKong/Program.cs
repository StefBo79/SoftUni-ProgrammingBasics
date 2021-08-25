using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            double extra = double.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());

            double decorPrice = filmBudget * 0.10;
            double totalCostumePrice = extra * costumePrice;

            if (extra > 150)
            {
                totalCostumePrice = totalCostumePrice * 0.90;
            }

            double budgetNeeded = decorPrice + totalCostumePrice;
            if (budgetNeeded > filmBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {budgetNeeded - filmBudget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - budgetNeeded:F2} leva left.");
            }
        }
    }
}