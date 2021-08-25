using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0;
            if (town == "Sofia")
            {
                if (sales > 0 && sales <= 500)
                {
                    commission = sales * 0.5 / 10;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.7 / 10;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.8 / 10;
                }
                else if (sales > 10000)
                {
                    commission = sales * 1.2 / 10;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
                Console.WriteLine($"{commission:F2}");
                }
            else if (town == "Varna")
            {
                if (sales > 0 && sales <= 500)
                {
                    commission = sales * 0.45 / 10;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.75 / 10;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 1.0 / 10;
                }
                else if (sales > 10000)
                {
                    commission = sales * 1.3 / 10;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
                Console.WriteLine($"{commission:F2}");
            }
            else if (town == "Plovdiv")
            {
                if (sales > 0 && sales <= 500)
                {
                    commission = sales * 0.55 / 10;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.8 / 10;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 1.2 / 10;
                }
                else if (sales > 10000)
                {
                    commission = sales * 1.45 / 10;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
                Console.WriteLine($"{commission:F2}");

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}