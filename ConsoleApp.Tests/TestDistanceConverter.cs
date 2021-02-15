using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
using System;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]

        ///<summary>
        ///Testing code for converting Miles to Feet
        ///using conversion values as accurate tests
        /// </summary>
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

        ///<summary>
        ///Testing code for converting Feet to Miles
        ///using conversion values as accurate tests
        /// </summary>
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

        ///<summary>
        ///Testing code for converting Miles to Metres
        ///using conversion values as accurate tests 
        /// </summary>
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


        ///<summary>
        ///Testing code for converting Metres to Miles
        ///using conversion values as accurate tests 
        /// </summary>
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

        ///<summary>
        ///Testing code for converting Feet to Metres
        ///using conversion values as accurate tests
        ///Included use of Math Rounding to reflect requirements.
        /// </summary>
        public void TestFeetToMetres()
        {
            //Arrange stage
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Metres;
            converter.FromDistance = 1;

            //Act Stage
            converter.CalculateDistance();
            double expectedDistance = 0.30;

            //Assert Stage
            Assert.AreEqual(expectedDistance, Math.Round(converter.ToDistance,2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for converting Metres to Feet
        ///using conversion values as accurate tests. 
        ///Included use of Math Rounding to reflect requirements.
        /// </summary>
        public void TestMetresToFeet()
        {
            //Arrange stage
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Feet;
            converter.FromDistance = 0.30;

            //Act Stage
            converter.CalculateDistance();
            double expectedDistance = 1;

            //Assert Stage
            Assert.AreEqual(expectedDistance, Math.Round(converter.ToDistance,0));
        }
    }
}
