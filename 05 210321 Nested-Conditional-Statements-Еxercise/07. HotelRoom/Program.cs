using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50.00;
                apartmentPrice = 65.00;
                if (numberOfNights > 14)
                {
                    studioPrice *= 0.70;
                    apartmentPrice *= 0.90;
                }
                else if (numberOfNights > 7) 
                {
                    studioPrice *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                if (numberOfNights > 14)
                {
                    studioPrice *= 0.80;
                    apartmentPrice *= 0.90;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76.00;
                apartmentPrice = 77.00;
                if (numberOfNights > 14)
                {
                    apartmentPrice *= 0.90;
                }
            }
            double totalApartmentPrice = numberOfNights * apartmentPrice;
            double totalStudioPrice = numberOfNights * studioPrice;

            Console.WriteLine($"Apartment: {totalApartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
        }
    }
}

