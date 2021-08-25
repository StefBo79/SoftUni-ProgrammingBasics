using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numOfflowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            const double rosesPrice = 5;
            const double dahliasPrice = 3.80;
            const double tulipsPrice = 2.80;
            const double narcissusPrice = 3;
            const double gladiolusPrice = 2.5;

            double discount = 1;
            double price = 0;

            if (flowers == "Roses")
            {
                price = rosesPrice;
                if (numOfflowers > 80)
                {
                    discount = 0.9;
                }
            }
            else if (flowers == "Dahlias")
            {
                price = dahliasPrice;
                if (numOfflowers > 90)
                {
                    discount = 0.85;
                }
            }
            else if (flowers == "Tulips")
            {
                price = tulipsPrice;
                if (numOfflowers > 80)
                {
                    discount = 0.85;
                }
            }
            else if (flowers == "Narcissus")
            {
                price = narcissusPrice;
                if (numOfflowers < 120)
                {
                    discount = 1.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                price = gladiolusPrice;
                if (numOfflowers < 80)
                {
                    discount = 1.20;
                }
            }

            double totalprice = (numOfflowers * price) * discount;
            if (budget >= totalprice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfflowers} {flowers} and {budget - totalprice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalprice - budget:F2} leva more.");
            }
        }
    }
}