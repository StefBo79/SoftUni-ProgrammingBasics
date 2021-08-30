using System;

namespace AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalking = int.Parse(Console.ReadLine());
            int numOfWalks = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());

            int totalMinutesWalking = minutesWalking * numOfWalks;
            int caloriesBurned = totalMinutesWalking * 5;

            int caloriesToBurn = totalCalories / 2;

            if (caloriesBurned >= caloriesToBurn)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
            }
        }
    }
}
