using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FantasyDrafter
{
    class PlayApp
    {
        List<Player> players = new List<Player>();
        List<MyTeam> myTeam = new List<MyTeam>();

        public PlayApp() { }

        public void GetPlayerInfo()
        {
            players.Add(new Player("Saquon Barkley", "RB", "NYG", 0));
            players.Add(new Player("Todd Gurley", "RB", "LAR", 0));
            players.Add(new Player("Alvin Kamara", "RB", "NO", 0));
            players.Add(new Player("David Johnson", "RB", "ARI", 0));

        }

        public void PrintList()
        {
            for (int j = 0; j < players.Count; j++)
            {
                Console.WriteLine(players[j].ToString());
            }
        }

        public void GetPick()
        {
            Console.Write("What is your pick?: ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(players[choice - 1]);
            Console.WriteLine();
            Console.Write("Are you sure you want to pick this player? (y/n): ");
            string input = Console.ReadLine().Trim().ToLower();
            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();

            if (input == "y")
            {
                Console.WriteLine("Alrighty then");
                Console.WriteLine();
                Console.WriteLine("...");
                Console.WriteLine();
                players.ToList(players[choice - 1]);
                myTeam.Add([choice - 1]);
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("...");
                Console.WriteLine();
                GetPick();
            }
        }
    }
}
