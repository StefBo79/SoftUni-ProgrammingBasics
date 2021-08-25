using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPricePerKg = double.Parse(Console.ReadLine());
            double babanasKg = double.Parse(Console.ReadLine());
            double orangesKg = double.Parse(Console.ReadLine());
            double rasberriesKg = double.Parse(Console.ReadLine());
            double strawberriesKg = double.Parse(Console.ReadLine());

            double rasberriesPricePerKg = strawberryPricePerKg / 2;
            double orangePricePerKg = rasberriesPricePerKg - (rasberriesPricePerKg * 0.4);
            double bananasPricePerKg = rasberriesPricePerKg - (rasberriesPricePerKg * 0.8);

            double rasberriesPrice = rasberriesPricePerKg * rasberriesKg;
            double strawberriesPrice = strawberryPricePerKg * strawberriesKg;
            double orancePrice = orangePricePerKg * orangesKg;
            double bananasPrice = bananasPricePerKg * babanasKg;

            double totalPrice = strawberriesPrice + rasberriesPrice + orancePrice + bananasPrice;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}