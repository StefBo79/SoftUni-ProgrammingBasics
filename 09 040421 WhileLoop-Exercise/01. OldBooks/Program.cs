using System;

namespace While_Loop_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int counter = 0;
            bool isTheBookFound = false;

            string nextBookName = Console.ReadLine();
            while (nextBookName != "No More Books")
            {
                if (nextBookName == favoriteBook)
                {
                    isTheBookFound = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();
            }
            if (isTheBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
