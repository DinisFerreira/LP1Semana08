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
                new Player("Kratos", 6969),
                new Player("Drake", 4200)
            };
        }

