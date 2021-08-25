using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpaceVolume = width * length * height;

            string input = Console.ReadLine();
            while (input != "Done")
            {
                int boxes = int.Parse(input);
                freeSpaceVolume -= boxes;
                if (freeSpaceVolume <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpaceVolume)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{freeSpaceVolume} Cubic meters left.");
            }
        }
    }
}