using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input - numOfDays, typeOfRoom, feedback
            int numOfDays = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string feedback = Console.ReadLine();

            // 2. Check the type of room and find the price per night
            // 3. Check the type of room and numOfDays and find the discount
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
                case "president apartment": pricePerNight = 35;
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
            switch (typeOfRoom)
            {
                case "apartment":
                    
                case "president apartment":
                    

                default:
                    break;
            }
            // 4. Calculate the total  price of the holiday and substract the discount
            double total = pricePerNight * (numOfDays - 1);
            total -= total * discount;

            // 5. Check the feedback, if positive + 25%, if negative - 10%
            if (feedback == "positive")
            {
                total += total * 0.25;
            }
            else
            {
                total -= total * 0.10;
            }
            // 6. Print the result
            Console.WriteLine($"{total:F2}");
        }
    }
}