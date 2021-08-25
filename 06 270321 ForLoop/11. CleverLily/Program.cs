using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            int toysCount = 0;
            double moneyFromBirthdays = 0;
            int birthdayMoney = 10;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    toysCount++;
                }
                else
                {
                    moneyFromBirthdays += birthdayMoney;
                    birthdayMoney += 10;
                    moneyFromBirthdays--;
                }
            }
            double moneyFromToys = toysCount * toysPrice;
            double totalMoneyCollected = moneyFromBirthdays + moneyFromToys;

            if (totalMoneyCollected >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {totalMoneyCollected - washingMachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - totalMoneyCollected:F2}");
            }
        }
    }
}

