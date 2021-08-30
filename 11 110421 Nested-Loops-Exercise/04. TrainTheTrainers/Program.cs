using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            int countOfPresentations = 0;
            double totalSumOfGrades = 0;

            while (presentation != "Finish")
            {
                countOfPresentations++;
                double sumOfGrades = 0;
                
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                    
                }
                double averageGrade = sumOfGrades / n;
                Console.WriteLine($"{presentation} - {averageGrade:F2}.");
                totalSumOfGrades += averageGrade;
                presentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalSumOfGrades / countOfPresentations:F2}.");
        }
    }
}
