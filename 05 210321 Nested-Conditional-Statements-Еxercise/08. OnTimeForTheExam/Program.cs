using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArriving = int.Parse(Console.ReadLine());
            int minuteOfArriving = int.Parse(Console.ReadLine());

            //преобразуване
            int examInMinutes = hourOfExam * 60 + minuteOfExam;
            int arrivingInMinutes = hourOfArriving * 60 + minuteOfArriving;

            //логика
            if (arrivingInMinutes > examInMinutes)
            {
                Console.WriteLine("Late");
                int lateInMinutes = arrivingInMinutes - examInMinutes;
                int lateHours = lateInMinutes / 60;
                int lateMinutes = lateInMinutes % 60;
                if (lateInMinutes >= 60)
                {
                    Console.WriteLine($"{lateHours}:{lateMinutes:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{lateMinutes} minutes after the start");
                }
            }
            else if (arrivingInMinutes == examInMinutes || examInMinutes - arrivingInMinutes <= 30)
            {
                Console.WriteLine("On time");
                int earlyInMinutes = examInMinutes - arrivingInMinutes;
                int earlyMinutes = earlyInMinutes % 60;

                if (earlyInMinutes != 60)
                {
                    Console.WriteLine($"{earlyMinutes} minutes before the start");
                }

            }
            else if (examInMinutes - arrivingInMinutes > 30)
            {
                Console.WriteLine("Early");
                int earlyInMinutes = examInMinutes - arrivingInMinutes;
                int earlyMinutes = earlyInMinutes % 60;
                int earlyHours = earlyInMinutes / 60;
                if (earlyInMinutes < 60)
                {
                    Console.WriteLine($"{earlyMinutes} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{earlyHours}:{earlyMinutes:d2} hours before the start");
                }
            }
        }
    }
}