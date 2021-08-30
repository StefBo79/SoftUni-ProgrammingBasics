using System;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double sumToReach = double.Parse(Console.ReadLine());

            double slipsPrice = tshirtPrice * 0.75;
            double socksPrice = slipsPrice * 0.20;
            double snickersPrice = (tshirtPrice + slipsPrice) * 2;

            double totalPrice = tshirtPrice + slipsPrice + socksPrice + snickersPrice;
            double discount = totalPrice * 0.15;
            double finalPrice = totalPrice - discount;

            if (finalPrice >= sumToReach)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {finalPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {sumToReach - finalPrice:f2} lv. more.");
            }
        }
    }
}
