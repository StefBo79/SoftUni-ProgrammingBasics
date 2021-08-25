using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNumber = int.MinValue;


            while (input != "Stop")
            {
                int num = int.Parse(input);
                input = Console.ReadLine();
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
