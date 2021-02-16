using System;
using ConsoleHelpers;


namespace ConsoleAppProject.App05
{
    class GameView
    {
        private Game game;

        public void Play()
        {
            //change to false of playing more than one game
            bool wantToQuit = true;

            do
            {
                StartGame();

                GetPlayerChoice();
                DisplayChoice(game.Human.Choice);
               // DisplayChoice(GameChoices.Scissors);

                game.MakeComputerChoice();
                //DisplayChoice(game.Computer.Choice);
                DisplayChoice(GameChoices.Scissors);

                game.ScoreRound();

                if (game.Round == game.LastRound)
                {
                    Console.WriteLine();
                    //display whos won and the score here
                    //better to call a seperate method
                }
            } while (!wantToQuit);

        }

        private void GetPlayerChoice()
        {
        }
        private void StartGame()
        {
            SetupConsole();
            
            ConsoleHelper.OutputHeading("    Rock-Paper-Scissors Game");

            if (game == null)
            {
                Console.Write("  Please enter your name > ");
                string name = Console.ReadLine();

                game = new Game(name);
            }

            game.Start();
        }

        private void SetupConsole()
        {
            Console.SetWindowSize(100, 40);
            Console.SetBufferSize(100, 40);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

        }

       

        private void DisplayChoice(GameChoices choice)
        {
            if(choice == GameChoices.Scissors)
            {
                GameImages.DrawScissors(10, 10);
            }
        }

        
    }
}
