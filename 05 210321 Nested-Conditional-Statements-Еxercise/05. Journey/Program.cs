using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            string place = string.Empty;
            double price = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    price = budget * 0.30;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    price = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    price = budget * 0.40;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    price = budget * 0.80;
                }
            }
            else
            {
                destination = "Europe";
                place = "Hotel";
                price = budget * 0.90;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {price:F2}");
        }
        }
    }