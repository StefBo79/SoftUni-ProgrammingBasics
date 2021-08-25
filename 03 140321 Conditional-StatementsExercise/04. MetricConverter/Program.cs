using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            string inputmetric = Console.ReadLine();
            string outputmetric = Console.ReadLine();

            double inputNumberInCm = inputNumber;
            if (inputmetric == "mm")
            {
                inputNumberInCm = inputNumber / 10;
            }
            else if (inputmetric == "m") 
            {
                inputNumberInCm = inputNumber * 100;
            }

            double outputNumber = inputNumberInCm;
            if (outputmetric == "mm")
            {
                outputNumber = inputNumberInCm * 10;
            }
            if (outputmetric == "m") 
            {
                outputNumber = inputNumberInCm / 100;
            }
            Console.WriteLine($"{outputNumber:F3}");
        }
    }
}