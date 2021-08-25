using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double note = double.Parse(Console.ReadLine());
            double averageSum = 0;
            int grade = 1;

            while (note >= 4.00)
            {
                averageSum += note;
                if (grade < 12)
                {
                    grade++;
                }
                else
                {
                    Console.WriteLine($"{name} graduated. Average grade: {(averageSum / 12):f2}");
                    Environment.Exit(0);
                }
                note = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{name} has been excluded at {grade} grade");
        }
    }
}