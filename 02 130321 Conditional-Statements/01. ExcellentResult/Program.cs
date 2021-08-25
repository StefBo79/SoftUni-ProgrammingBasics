using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50) 
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}