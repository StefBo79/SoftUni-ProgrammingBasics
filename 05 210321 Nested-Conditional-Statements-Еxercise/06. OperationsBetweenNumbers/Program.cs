using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();

            double result = 0;
            string bonus = "";
            if (action == "+")
            {
                result = firstNumber + secondNumber;
                if (result % 2 == 0)
                {
                    bonus = "even";
                }
                else
                {
                    bonus = "odd";
                }
                Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - {bonus}");
            }
            else if (action == "-")
            {
                result = firstNumber - secondNumber;
                if (result % 2 == 0)
                {
                    bonus = "even";
                }
                else
                {
                    bonus = "odd";
                }
                Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - {bonus}");
            }
            else if (action == "*")
            {
                result = firstNumber * secondNumber;
                if (result % 2 == 0)
                {
                    bonus = "even";
                }
                else
                {
                    bonus = "odd";
                }
                Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - {bonus}");
            }
            else if (action == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                    return;
                }
                result = firstNumber / secondNumber;
                Console.WriteLine($"{firstNumber} / {secondNumber} = {result:F2}");
            }
            else if (action == "%")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                    return;
                }
                result = firstNumber % secondNumber;
                Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
            }

        }
    }
}