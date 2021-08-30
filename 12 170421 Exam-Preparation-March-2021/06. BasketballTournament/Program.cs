using System;

namespace BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalGames = 0;
            int numOfWins = 0;
            int numOfLost = 0;

            string input = Console.ReadLine();

            while (input != "End of tournaments")
            {
                int n = int.Parse(Console.ReadLine());
                totalGames += n;

                for (int i = 1; i <= n; i++)
                {
                    int DesiTeamPoints = int.Parse(Console.ReadLine());
                    int OpponentTeamPoints = int.Parse(Console.ReadLine());

                    if (DesiTeamPoints > OpponentTeamPoints)
                    {
                        Console.WriteLine($"Game {i} of tournament {input}: win with {DesiTeamPoints - OpponentTeamPoints} points.");
                        numOfWins++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {input}: lost with {OpponentTeamPoints - DesiTeamPoints} points.");
                        numOfLost++;
                    }
                }
                
                
                
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"{(double)numOfWins / totalGames * 100:f2}% matches win");
            Console.WriteLine($"{(double)numOfLost / totalGames * 100:f2}% matches lost");
        }
    }
}
