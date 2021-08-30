using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfGroups = int.Parse(Console.ReadLine());
            int musala = 0;
            int montblanc = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 0; i < numOfGroups; i++)
            {
                int numOfPeople = int.Parse(Console.ReadLine());

                if (numOfPeople <= 5)
                {
                    musala += numOfPeople;
                }
                else if (numOfPeople >= 6 && numOfPeople <= 12)
                {
                    montblanc += numOfPeople;
                }
                else if (numOfPeople >= 13 && numOfPeople <= 25)
                {
                    kilimandjaro += numOfPeople;
                }
                else if (numOfPeople >= 26 && numOfPeople <= 40)
                {
                    k2 += numOfPeople;
                }
                else
                {
                    everest += numOfPeople;
                }
            }
            int totalPeople = musala + montblanc + kilimandjaro + k2 + everest;

            double percentGoingToMusala = (double) musala / totalPeople * 100;
            double percentGoingToMontBlanc = (double)montblanc / totalPeople * 100;
            double percentGoingToKilimandjaro = (double)kilimandjaro / totalPeople * 100;
            double percentGoingTok2 = (double)k2 / totalPeople * 100;
            double percentGoingToEverest = (double)everest / totalPeople * 100;

            Console.WriteLine($"{percentGoingToMusala:f2}%");
            Console.WriteLine($"{percentGoingToMontBlanc:f2}%");
            Console.WriteLine($"{percentGoingToKilimandjaro:f2}%");
            Console.WriteLine($"{percentGoingTok2:f2}%");
            Console.WriteLine($"{percentGoingToEverest:f2}%");
        }
    }
}
