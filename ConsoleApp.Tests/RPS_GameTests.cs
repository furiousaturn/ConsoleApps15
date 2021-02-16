using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App05;


namespace ConsoleApp.Tests
{
    [TestClass]
    public class RPS_GameTests
    {
        private Game game = new Game("Fred");
        
        [TestMethod]
        public void TestGameStart()
        { 
            //Act
            game.Start();

            //Assert
            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(0, game.Computer.Score);
            Assert.AreEqual(1, game.Round);

            Assert.AreEqual(GamePlayers.Player, game.CurrentPlayer.PlayerType);

            Assert.AreEqual("Fred", game.Human.Name);
            Assert.AreEqual("Computer", game.Computer.Name);
        }

        [TestMethod]
        public void TestComputerChoiceIsRandom()
        {
            //Arrange
            int[] choices = new int[4];
            
            //Act
            game.Start();
            for(int i = 0; i < 10000; i++)
            {
                game.MakeComputerChoice();
                int choiceNo = (int)game.Computer.Choice;
                choices[choiceNo]++;
            }

            //Assert
            Assert.IsTrue(choices[0] == 0);
            Assert.IsTrue(choices[1] > 3000);
            Assert.IsTrue(choices[2] > 3000);
            Assert.IsTrue(choices[3] > 3000);
        }

        [TestMethod]
        public void TestScoreRoundRockPaper()
        {
            //Arrange
            game.Start();
            game.Human.Choice = GameChoices.Rock;
            game.Computer.Choice = GameChoices.Paper;

            //Act
            game.ScoreRound();

            //Assert
            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(2, game.Computer.Score);
            Assert.AreEqual(game.Winner.PlayerType, GamePlayers.Computer);
        }









    }
}
