using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int pastryCook = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffels = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double dailyCakesIncomePerCook = cakes * 45;
            double dailyWaffelsIncomePerCook = waffels * 5.8;
            double dailyPancakesIncomePerCook = pancakes * 3.2;
            double totalIncome = (dailyCakesIncomePerCook + dailyPancakesIncomePerCook + dailyWaffelsIncomePerCook) * pastryCook * days;
            double moneyRaised = totalIncome - (totalIncome / 8);
            Console.WriteLine(moneyRaised);
        }
    }
}