using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForVacantion = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;

            while (currentMoney < moneyNeededForVacantion && spendingCounter < 5)
            {
                string action = Console.ReadLine();
                double moneyFromAction = double.Parse(Console.ReadLine());
                daysCounter++;
                if (action == "save")
                {
                    currentMoney += moneyFromAction;
                    //daysCounter -= 1;
                    spendingCounter = 0;
                }
                else
                {
                    currentMoney -= moneyFromAction;
                    spendingCounter++;
                    //daysCounter++;
                    
                    if (currentMoney < 0)
                    {
                        currentMoney = 0;
                    }
                }
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (currentMoney >= moneyNeededForVacantion)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
