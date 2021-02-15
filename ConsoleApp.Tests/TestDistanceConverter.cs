using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            //Arrange stage
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Feet;
            converter.FromDistance = 1.0;
            
            //Act Stage
            converter.CalculateDistance();
            double expectedDistance = 5280;

            //Assert Stage
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            //Arrange stage
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;
            converter.FromDistance = 5280;

            //Act Stage
            converter.CalculateDistance();
            double expectedDistance = 1;

            //Assert Stage
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMilesToMetres()
        {
            //Arrange stage
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Metres;
            converter.FromDistance = 1;

            //Act Stage
            converter.CalculateDistance();
            double expectedDistance = 1609.34;

            //Assert Stage
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMetresToMiles()
        {
            //Arrange stage
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Miles;
            converter.FromDistance = 1609.34;

            //Act Stage
            converter.CalculateDistance();
            double expectedDistance = 1;

            //Assert Stage
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestFeetToMetres()
        {
            //Arrange stage
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Metres;
            converter.FromDistance = 1;

            //Act Stage
            converter.CalculateDistance();
            double expectedDistance = 0.3047999902464003;

            //Assert Stage
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMetresToFeet()
        {
            //Arrange stage
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Feet;
            converter.FromDistance = 0.3047999902464003;

            //Act Stage
            converter.CalculateDistance();
            double expectedDistance = 1;

            //Assert Stage
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}
