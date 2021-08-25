using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int totalVolume = length * width * height;
            double totalLiters = totalVolume * 0.001;
            percentage = percentage * 0.01;
            double totalRealLiters = totalLiters * (1 - percentage);

            Console.WriteLine(totalRealLiters);
        }
    }
}