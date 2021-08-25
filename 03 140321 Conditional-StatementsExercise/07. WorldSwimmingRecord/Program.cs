using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double TimeInSecondsForMeter = double.Parse(Console.ReadLine());

            double recordAttemptInSecounds = distanceInMeters * TimeInSecondsForMeter;
            double amountOfTimeSlowedDown = Math.Floor(distanceInMeters / 15);
            recordAttemptInSecounds = recordAttemptInSecounds + (amountOfTimeSlowedDown * 12.5);

            if (recordAttemptInSecounds < recordInSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {recordAttemptInSecounds:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {recordAttemptInSecounds - recordInSeconds:F2} seconds slower.");
            }
        }
    }
}