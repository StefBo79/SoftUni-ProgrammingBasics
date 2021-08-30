using System;

namespace preperationExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string company = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidsTickets = int.Parse(Console.ReadLine());
            double adultTicketPrice = double.Parse(Console.ReadLine());
            double fee = double.Parse(Console.ReadLine());

            double kidsTicketPrice = adultTicketPrice * 0.30;
            double total = (adultTicketPrice + fee) * adultTickets + (kidsTicketPrice + fee) * kidsTickets;

            double profit = total * 0.20;

            Console.WriteLine($"The profit of your agency from {company} tickets is {profit:f2} lv.");

        }
    }
}