using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] p = { 0, 0, 0, 0, 0 };
            

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p[0]++;
                }
                else if (number < 400)
                {
                    p[1]++;
                }
                else if (number < 600)
                {
                    p[2]++;
                }
                else if (number < 800)
                {
                    p[3]++;
                }
                else
                {
                    p[4]++;
                }
            }
            Console.WriteLine($"{(p[0] / n * 100):f2}%");
            Console.WriteLine($"{(p[1] / n * 100):f2}%");
            Console.WriteLine($"{(p[2] / n * 100):f2}%");
            Console.WriteLine($"{(p[3] / n * 100):f2}%");
            Console.WriteLine($"{(p[4] / n * 100):f2}%");
            
        }
    }
}