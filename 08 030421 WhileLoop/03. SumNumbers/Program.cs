using System;

namespace SumNumberss
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < n)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
