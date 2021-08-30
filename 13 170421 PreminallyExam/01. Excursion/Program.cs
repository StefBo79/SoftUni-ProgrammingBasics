using System;

namespace PreminallyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfPeople = double.Parse(Console.ReadLine());
            double numOfNights = double.Parse(Console.ReadLine());
            double numOfTransportCards = double.Parse(Console.ReadLine());
            double numOfMuseumTickets = double.Parse(Console.ReadLine());

            double nightPrice = 20;
            double TransportCardPrice = 1.60;
            double MuseumTicketPrice = 6;

            double totalNights = numOfNights * nightPrice;
            double totalTransportCards = numOfTransportCards * TransportCardPrice;
            double totalMuseumTickets = numOfMuseumTickets * MuseumTicketPrice;

            double totalPricePerPerson = totalNights + totalTransportCards + totalMuseumTickets;
            double totalPricePerGroup = totalPricePerPerson * numOfPeople;
            double aditionalCost = totalPricePerGroup * 0.25;
            double grandTotal = totalPricePerGroup + aditionalCost;

            Console.WriteLine($"{grandTotal:f2}");

        }
    }
}