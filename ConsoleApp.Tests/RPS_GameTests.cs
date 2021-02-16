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
        ///<summary>
        ///Test scoring when Human=Rock, Computer=Paper
        /// </summary>
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

        [TestMethod]
        ///<summary>
        ///Test scoring when Human=Paper, Computer=Rock
        /// </summary>
        public void TestScoreRoundPaperRock()
        {
            //Arrange
            game.Start();
            game.Human.Choice = GameChoices.Paper;
            game.Computer.Choice = GameChoices.Rock;

            //Act
            game.ScoreRound();

            //Assert
            Assert.AreEqual(2, game.Human.Score);
            Assert.AreEqual(0, game.Computer.Score);
            Assert.AreEqual(game.Winner.PlayerType, GamePlayers.Player);
        }

        [TestMethod]
        ///<summary>
        ///Test scoring when Human=Rock, Computer=Scissors
        /// </summary>
        public void TestScoreRoundRockScissors()
        {
            //Arrange
            game.Start();
            game.Human.Choice = GameChoices.Rock;
            game.Computer.Choice = GameChoices.Scissors;

            //Act
            game.ScoreRound();

            //Assert
            Assert.AreEqual(2, game.Human.Score);
            Assert.AreEqual(0, game.Computer.Score);
            Assert.AreEqual(game.Winner.PlayerType, GamePlayers.Player);
        }

        [TestMethod]
        ///<summary>
        ///Test scoring when Human=Scissors, Computer=Rock
        /// </summary>
        public void TestScoreRoundScissorsRock()
        {
            //Arrange
            game.Start();
            game.Human.Choice = GameChoices.Scissors;
            game.Computer.Choice = GameChoices.Rock;

            //Act
            game.ScoreRound();

            //Assert
            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(2, game.Computer.Score);
            Assert.AreEqual(game.Winner.PlayerType, GamePlayers.Computer);
        }

        [TestMethod]
        ///<summary>
        ///Test scoring when Human=Paper, Computer=Scissors
        /// </summary>
        public void TestScoreRoundPaperScissors()
        {
            //Arrange
            game.Start();
            game.Human.Choice = GameChoices.Paper;
            game.Computer.Choice = GameChoices.Scissors;

            //Act
            game.ScoreRound();

            //Assert
            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(2, game.Computer.Score);
            Assert.AreEqual(game.Winner.PlayerType, GamePlayers.Computer);
        }

        [TestMethod]
        ///<summary>
        ///Test scoring when Human=Scissors, Computer=Paper
        /// </summary>
        public void TestScoreRoundScissorsPaper()
        {
            //Arrange
            game.Start();
            game.Human.Choice = GameChoices.Scissors;
            game.Computer.Choice = GameChoices.Paper;

            //Act
            game.ScoreRound();

            //Assert
            Assert.AreEqual(2, game.Human.Score);
            Assert.AreEqual(0, game.Computer.Score);
            Assert.AreEqual(game.Winner.PlayerType, GamePlayers.Player);
        }

        [TestMethod]
        ///<summary>
        ///Test scoring when Human=Rock, Computer=Rock
        /// </summary>
        public void TestScoreRoundRockRock()
        {
            //Arrange
            game.Start();
            game.Human.Choice = GameChoices.Rock;
            game.Computer.Choice = GameChoices.Rock;

            //Act
            game.ScoreRound();

            //Assert
            Assert.AreEqual(1, game.Human.Score);
            Assert.AreEqual(1, game.Computer.Score);
        }

        [TestMethod]
        ///<summary>
        ///Test scoring when Human=Scissors, Computer=Scissors
        /// </summary>
        public void TestScoreRoundScissorsScissors()
        {
            //Arrange
            game.Start();
            game.Human.Choice = GameChoices.Scissors;
            game.Computer.Choice = GameChoices.Scissors;

            //Act
            game.ScoreRound();

            //Assert
            Assert.AreEqual(1, game.Human.Score);
            Assert.AreEqual(1, game.Computer.Score);
        }

        [TestMethod]
        ///<summary>
        ///Test scoring when Human=Paper, Computer=Paper
        /// </summary>
        public void TestScoreRoundPaperPaper()
        {
            //Arrange
            game.Start();
            game.Human.Choice = GameChoices.Scissors;
            game.Computer.Choice = GameChoices.Scissors;

            //Act
            game.ScoreRound();

            //Assert
            Assert.AreEqual(1, game.Human.Score);
            Assert.AreEqual(1, game.Computer.Score);
        }

    }
}
