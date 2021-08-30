using System;

namespace SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDays = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string feedback = Console.ReadLine();

            double pricePerNight = 0;
            double discount = 0;

            switch (typeOfRoom)
            {
                case "room for one person": pricePerNight = 18; break;
                case "apartment": pricePerNight = 25;
                    if (numOfDays < 10)
                    {
                        discount = 0.30;
                    }
                    else if (numOfDays >= 10 && numOfDays <= 15)
                    {
                        discount = 0.35;
                    }
                    else if (numOfDays > 15)
                    {
                        discount = 0.50;
                    }
                    break;
                case "president apartment":
                    pricePerNight = 35;
                    if (numOfDays < 10)
                    {
                        discount = 0.10;
                    }
                    else if (numOfDays >= 10 && numOfDays <= 15)
                    {
                        discount = 0.15;
                    }
                    else if (numOfDays > 15)
                    {
                        discount = 0.20;
                    }
                    break;
            }
            double total = pricePerNight * (numOfDays - 1);
            total -= total * discount;

            if (feedback == "positive")
            {
                total += total * 0.25;
            }
            else
            {
                total -= total * 0.10;
            }
            Console.WriteLine($"{total:F2}");
        }
        }
    }

