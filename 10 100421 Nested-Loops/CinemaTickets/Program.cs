using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTickets = 0;
            int standartTickets = 0;
            int studentTickets = 0;
            int kidTickets = 0;

            string movie = Console.ReadLine();

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());

                int countOfTickets = 0;
                string ticket = Console.ReadLine();

                while (ticket != "End")
                {
                    switch (ticket)
                    {
                        case "standard":
                            standartTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                    }
                    countOfTickets++;
                    if (countOfTickets == availableSeats)
                    {
                        break;
                    }
                    ticket = Console.ReadLine();
                }
                totalTickets += countOfTickets;
                double percentOfSeatsTaken = (double)countOfTickets / availableSeats * 100;
                Console.WriteLine($"{movie} - {percentOfSeatsTaken:f2}% full.");
                movie = Console.ReadLine();
            }            
            Console.WriteLine($"Total tickets: {totalTickets}");

            double percentOfStandartTickets = (double)standartTickets / totalTickets * 100;
            double percentOfStudentTickets = (double)studentTickets / totalTickets * 100;
            double percentOfKidTickets = (double)kidTickets / totalTickets * 100;

            Console.WriteLine($"{percentOfStudentTickets:f2}% student tickets.");
            Console.WriteLine($"{percentOfStandartTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentOfKidTickets:f2}% kids tickets.");
        }
    }
}