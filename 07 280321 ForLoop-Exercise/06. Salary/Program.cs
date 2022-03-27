using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string openTab = Console.ReadLine();

                if (openTab == "Facebook")
                {
                    salary -= 150;
                }
                else if (openTab == "Instagram")
                {
                    salary -= 100;
                }
                else if (openTab == "Reddit")
                {
                    salary -= 50;
                }
                else if (openTab != "Facebook" || openTab != "Instagram" || openTab != "Redid")
                {
                    continue;
                }
                if (salary <= 0)
                {                    
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);                
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }            
        }
    }
}
