using System;

namespace TradeCommissionsSwitchVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            switch (town)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500) Console.WriteLine($"{sales * 0.05:F2}");
                    else if (sales > 500 && sales <= 1000) Console.WriteLine($"{sales * 0.07:F2}");
                    else if (sales > 1000 && sales <= 10000) Console.WriteLine($"{sales * 0.08:F2}");
                    else if (sales > 10000) Console.WriteLine($"{sales * 0.12:F2}");
                    else Console.WriteLine("error"); break;
                case "Varna":
                    if (sales >= 0 && sales <= 500) Console.WriteLine($"{sales * 0.045:F2}");
                    else if (sales > 500 && sales <= 1000) Console.WriteLine($"{sales * 0.075:F2}");
                    else if (sales > 1000 && sales <= 10000) Console.WriteLine($"{sales * 0.10:F2}");
                    else if (sales > 10000) Console.WriteLine($"{sales * 0.13:F2}");
                    else Console.WriteLine("error"); break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500) Console.WriteLine($"{sales * 0.055:F2}");
                    else if (sales > 500 && sales <= 1000) Console.WriteLine($"{sales * 0.08:F2}");
                    else if (sales > 1000 && sales <= 10000) Console.WriteLine($"{sales * 0.12:F2}");
                    else if (sales > 10000) Console.WriteLine($"{sales * 0.145:F2}");
                    else Console.WriteLine("error"); break;
                default: Console.WriteLine("error"); break;
            }
        }
    }
}
//Град     0 ≤ s ≤ 500 500 < s ≤ 1 000 1 000 < s ≤ 10 000  s > 10 000
//Sofia        5 %           7 %               8%          12 %
//Varna        4.5 %         7.5 %             10 %        13 %
//Plovdiv      5.5 %          8 %              12 %        14.5 %
