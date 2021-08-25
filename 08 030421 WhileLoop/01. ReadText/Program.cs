using System;

namespace While_Loop_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                Console.WriteLine(input);
            }
        }
    }
}