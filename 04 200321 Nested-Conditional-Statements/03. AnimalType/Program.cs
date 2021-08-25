using System;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animail = Console.ReadLine();

            switch (animail)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
