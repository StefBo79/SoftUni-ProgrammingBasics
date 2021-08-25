using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimumSalary = double.Parse(Console.ReadLine());

            double socialScholarShip = 0;
            if (income < minimumSalary && averageGrade >= 4.50)
            {
                socialScholarShip = Math.Floor(minimumSalary * 0.35);
            }

            double excelentScholarShip = 0;
            if (averageGrade >= 5.50)
            {
                excelentScholarShip = Math.Floor(averageGrade * 25);
            }
            if (socialScholarShip == 0 && excelentScholarShip == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialScholarShip > 0 && excelentScholarShip > 0)
            {
                if (socialScholarShip > excelentScholarShip)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {socialScholarShip} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excelentScholarShip} BGN");
                }
            }
            else if (socialScholarShip > 0)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarShip} BGN");
            }
            else if (excelentScholarShip > 0)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excelentScholarShip} BGN");
            }
        }
    }
}