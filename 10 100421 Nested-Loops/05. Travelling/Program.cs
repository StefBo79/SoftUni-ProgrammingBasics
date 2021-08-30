using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            

            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < minBudget)
                {
                    double money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
