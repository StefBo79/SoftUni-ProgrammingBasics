using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallRentPrice = double.Parse(Console.ReadLine());
            double cakePrice = hallRentPrice * 0.2;
            double drinkPrice = cakePrice * 0.55;
            double animatorPrice = hallRentPrice / 3 ;
            double sum = (hallRentPrice + cakePrice + drinkPrice + animatorPrice);
            Console.WriteLine(sum);
        }
    }
}