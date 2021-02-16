using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
    /// <summary>
    /// 
    /// </summary>
    public class Game
    {
        //Attributes
        public const int MaximumRound = 10;

        public int Round { get; set; }

        public Player Human { get; }
        public Player Computer { get; }

        public Player CurrentPlayer { get; set; }

        public Player Winner { get; set; }

        private Random generator = new Random();

        public int LastRound { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        public Game(string name)
        {
            Human = new Player(name, GamePlayers.Player);
            Computer = new Player("Computer", GamePlayers.Computer);
            Round = 0;
         }

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            Round = 1;
            LastRound = 5;
            CurrentPlayer = Human;
            Human.Score = 0;
            Computer.Score = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public void MakeComputerChoice()
        {
            int choice = generator.Next(1,4);

            switch(choice)
            {
                case 1: Computer.Choice = GameChoices.Paper; break;
                case 2: Computer.Choice = GameChoices.Rock; break;
                case 3: Computer.Choice = GameChoices.Scissors; break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ScoreRound()
        {
            if (Human.Choice == GameChoices.Rock &&
                Computer.Choice == GameChoices.Paper)
            {
                Computer.Score += 2;
                Winner = Computer;
            }
            else if (Human.Choice == GameChoices.Paper &&
                Computer.Choice == GameChoices.Rock)
            {
                Human.Score += 2;
                Winner = Human;
            }
            else if (Human.Choice == GameChoices.Rock &&
                Computer.Choice == GameChoices.Scissors)
            {
                Human.Score += 2;
                Winner = Human;
            }
            else if (Human.Choice == GameChoices.Scissors &&
                Computer.Choice == GameChoices.Rock)
            {
                Computer.Score += 2;
                Winner = Computer;
            }
            else if (Human.Choice == GameChoices.Paper &&
                Computer.Choice == GameChoices.Scissors)
            {
                Computer.Score += 2;
                Winner = Computer;
            }
            else if (Human.Choice == GameChoices.Scissors &&
                Computer.Choice == GameChoices.Paper)
            {
                Human.Score += 2;
                Winner = Human;
            }
            
            //capture 3 more possibilities - a tie.
            else
            {
                Human.Score += 1;
                Computer.Score += 1;
                Winner = null;
            }

            if (Round < LastRound)
            {
                Round++;
            }
            else End();
        }

        public void End()
        {
            if (Computer.Score > Human.Score)
            {
                Winner = Computer;
            }
            else if (Computer.Score < Human.Score)
            {
                Winner = Human;
            }
            else Winner = null;
        }
    }
}
