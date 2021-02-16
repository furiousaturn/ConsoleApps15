using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
    /// <summary>
    /// 
    /// </summary>
    class Game
    {
        //Attributes
        public const int MaximumRound = 10;

        public int Round { get; set; }

        public Player Human { get; }
        public Player Computer { get; }

        public Player CurrentPlayer { get; set; }

        public Player Winner { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Game(string name)
        {
            Human = new Player("Fred", GamePlayers.Player);
            Computer = new Player("Computer", GamePlayers.Computer);
            Round = 0;
         }

        public void Start()
        {
            Round = 1;
            CurrentPlayer = Human;
            Human.Score = 0;
            Computer.Score = 0;


        }
    }
}
