using System;
using System.Collections.Generic;

namespace PlayerManager2
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }

    public class PlayerManager
    {
        private List<Player> playerList;

        public PlayerManager()
        {
            playerList = new List<Player>()
            {
                new Player("luffy", 6969),
                new Player("pikachu", 4200)
            };
        }

        public void Start()
        {
            string option;

            do
            {
                ShowMenu();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        ListPlayers();
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case "4":
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
                        break;
                }

                Console.Write("\nPress any key to continue...");
                Console.ReadKey(true);
                Console.WriteLine("\n");

            } while (option != "4");
        }

        private void ShowMenu()
        {
            Console.WriteLine("Hi there, please choose an option (1, 2, 3, or 4):");
            Console.WriteLine("1- Insert Player");
            Console.WriteLine("2- Show Players and Scores");
            Console.WriteLine("3- Show Players with Score Greater Than");
            Console.WriteLine("4- Exit\n");
            Console.Write("Your option: ");
        }

        private void InsertPlayer()
        {
            Console.WriteLine("Insert name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Insert score: ");
            int score;
            while (!int.TryParse(Console.ReadLine(), out score))
            {
                Console.WriteLine("Invalid input! Please enter a valid integer for score.");
            }

            playerList.Add(new Player(name, score));
            Console.WriteLine("Player added successfully!");
        }

        private void ListPlayers()
        {
            Console.WriteLine("Players and Scores:");
            foreach (Player player in playerList)
            {
                Console.WriteLine($"{player.Name} {player.Score}");
            }
        }

        private void ListPlayersWithScoreGreaterThan()
        {
            Console.WriteLine("Insert minimum score: ");
            int minScore;
            while (!int.TryParse(Console.ReadLine(), out minScore))
            {
                Console.WriteLine("Invalid input! Please enter a valid integer for minimum score.");
            }

            Console.WriteLine($"Players with score greater than {minScore}:");
            foreach (Player player in playerList)
            {
                if (player.Score > minScore)
                {
                    Console.WriteLine($"{player.Name} {player.Score}");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            PlayerManager playerManager = new PlayerManager();
            playerManager.Start();
        }
    }
}
