using System;
using System.Collections.Generic;

namespace PlayerManager2
{
    public class Program
    {
        private List<Player> playerList;

        public static void Main()
        {
            Program prog = new Program();
            prog.Start();
        }

        public Program()
        {
            playerList = new List<Player>() {
                new Player("Luffy", 6969),
                new Player("Pikachu", 4200)
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
                        ListPlayers(playerList);
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
            Console.WriteLine("Hi there, please choose an option (1,2,3 or 4):");
            Console.WriteLine("1- Insert a player");
            Console.WriteLine("2- Show all players");
            Console.WriteLine("3- Show players with a score higher than...");
            Console.WriteLine("4- Leave the program :( \n");
            Console.Write("Your option: ");
        }

        private void InsertPlayer()
        {
            Console.WriteLine("Insert name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Insert score: ");
            string score = Console.ReadLine();
            int numScore = int.Parse(score);

            playerList.Add(new Player(name, numScore)); // Adicionando o novo jogador à lista.
        }

        private void ListPlayers(IEnumerable<Player> playersToList)
        {
            foreach (Player player in playersToList)
            {
                Console.WriteLine($"{player.Name} {player.Score}");
            }
        }

        private void ListPlayersWithScoreGreaterThan()
        {
            Console.WriteLine("Insert minimum score: ");
            string score = Console.ReadLine();
            int minScore = int.Parse(score);

            ListPlayers(GetPlayersWithScoreGreaterThan(minScore)); // Chamando o método ListPlayers diretamente.
        }

        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            foreach (Player player in playerList)
            {
                if (player.Score > minScore)
                {
                    yield return player;
                }
            }
        }
    }

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
}
