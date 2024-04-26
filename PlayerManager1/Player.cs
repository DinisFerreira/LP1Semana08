using System;

namespace PlayerManager2
{
    public class Player
    {
        // Campos privados
        private string name;
        private int score;

        // Propriedades públicas
        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }

        public int Score 
        { 
            get { return score; } 
            set { score = value; } 
        }

        // Construtor
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
