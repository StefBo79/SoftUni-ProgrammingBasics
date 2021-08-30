using System;

namespace Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfDays = double.Parse(Console.ReadLine());
            double kmFirstDay = double.Parse(Console.ReadLine());

            double sumOfKm = kmFirstDay;

            for (int i = 0; i < numOfDays; i++)
            {
                double percentNextDay = double.Parse(Console.ReadLine());
                kmFirstDay *= 1 + percentNextDay / 100.0;
                sumOfKm += kmFirstDay; 
            }
            if (sumOfKm >= 1000.00)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(sumOfKm - 1000.00)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000.00 - sumOfKm)} more kilometers");
            }
        }
    }
}

