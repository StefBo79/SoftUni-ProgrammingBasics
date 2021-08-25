using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearsType = Console.ReadLine();
            int vacantions = int.Parse(Console.ReadLine());
            int weekendsHomeCity = int.Parse(Console.ReadLine());
            int weekends = 48;
            int weekendsSofia = weekends - weekendsHomeCity;
            double saturdayPlays = 0.0;
            double sundayPlays = 0.0;
            double vacantionsPlay = vacantions * 2 / 3.0;
            double totalPlays = 0;
            saturdayPlays = weekendsSofia * 3 / 4.0;
            sundayPlays = weekendsHomeCity;
            if (yearsType == "leap") totalPlays = Math.Floor((sundayPlays + saturdayPlays + vacantionsPlay) * 1.15);
            else totalPlays = Math.Floor(sundayPlays + saturdayPlays + vacantionsPlay);
            Console.WriteLine(totalPlays);
        }
    }
}
