using System;

namespace Nested_Conditional_Statements_Еxercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int numOfraws = int.Parse(Console.ReadLine());
            int numOfcolumns = int.Parse(Console.ReadLine());

            double price = 0;

            if (typeOfProjection == "Premiere")
            {
                price = numOfraws * numOfcolumns * 12;
            }
            else if (typeOfProjection == "Normal")
            {
                price = numOfraws * numOfcolumns * 7.50;
            }
            else if (typeOfProjection == "Discount")
            {
                price = numOfraws * numOfcolumns * 5;
            }
            Console.WriteLine($"{price:F2} leva");
        }
    }
}