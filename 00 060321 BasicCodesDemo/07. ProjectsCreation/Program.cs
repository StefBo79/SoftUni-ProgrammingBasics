using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfArchitect = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int timeNeeded = numberOfProjects * 3;
            Console.WriteLine($"The architect {nameOfArchitect} will need {timeNeeded} hours to complete {numberOfProjects} project/s.");
        }
    }
}