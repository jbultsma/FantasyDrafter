using System;

namespace FantasyDrafter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 2019 Fantasy Football Draft in Chicago!");
            Console.WriteLine();
            Console.WriteLine("Josh, don't fuck it up");
            Run();
        }

        public static void Run()
        {
            Player p = new Player();
            PlayApp playerApp = new PlayApp();

            playerApp.GetPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();
            Console.WriteLine("Current Inventory:");
            Console.WriteLine();

            playerApp.PrintList();

            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();

            bool isAgain = false;

            do
            {
                playerApp.GetPick();
                playerApp.PrintList();

                Console.WriteLine();
                Console.Write("Another Pick? (y/n): ");
                string purchaseAgain = Console.ReadLine().ToLower().Trim();

                if (purchaseAgain == "y")
                {
                    isAgain = true;
                }

                else
                {
                    isAgain = false;
                }
            }
            while (isAgain == true);
        }
    }
}

