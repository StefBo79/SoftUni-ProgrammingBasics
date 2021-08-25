using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfDogs = int.Parse(Console.ReadLine());
            int countofAnimals = int.Parse(Console.ReadLine());
            double foodForDogsPrice = countOfDogs * 2.50;
            double foodForAnimalsPrice = countofAnimals * 4;
            double finalResult = foodForDogsPrice + foodForAnimalsPrice;
            Console.WriteLine($"{finalResult} lv.");
        }
    }
}