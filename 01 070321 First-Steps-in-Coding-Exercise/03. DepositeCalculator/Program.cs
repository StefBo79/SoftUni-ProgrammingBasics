using System;

namespace DepositeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int mounts = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());
            double result = deposit + mounts * ((deposit * (interest / 100)) / 12);
            Console.WriteLine(result);
        }
    }
}