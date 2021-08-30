using System;

namespace AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            string beverage = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numOfDrinks = int.Parse(Console.ReadLine());

            double price = 0;

            switch (beverage)
            {
                case "Espresso":
                    if (sugar == "Without")
                    {
                        price = 0.90;
                        price -= price * 0.35;
                    }
                    else if (sugar == "Normal")
                    {
                        price = 1;
                    }
                    else if (sugar == "Extra")
                    {
                        price = 1.20;
                    }
                    if (numOfDrinks >= 5)
                    {
                        price -= price * 0.25;
                    }
                    break;
                case "Cappuccino":
                    if (sugar == "Without")
                    {
                        price = 1;
                        price -= price * 0.35;
                    }
                    else if (sugar == "Normal")
                    {
                        price = 1.20;
                    }
                    else if (sugar == "Extra")
                    {
                        price = 1.60;
                    }
                    break;
                case "Tea":
                    if (sugar == "Without")
                    {
                        price = 0.50;
                        price -= price * 0.35;
                    }
                    else if (sugar == "Normal")
                    {
                        price = 0.60;
                    }
                    else if (sugar == "Extra")
                    {
                        price = 0.70;
                    }
                    break;
            }
            double totalPrice = numOfDrinks * price;
            if (totalPrice > 15)
            {
                totalPrice -= totalPrice * 0.20;
             
            }
            Console.WriteLine($"You bought {numOfDrinks} cups of {beverage} for {totalPrice:f2} lv.");

        }
    }
}