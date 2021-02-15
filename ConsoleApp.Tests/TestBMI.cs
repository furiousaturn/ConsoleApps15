using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;
using System;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestBMI
    {
        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Metric Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Centimetres(CM) and weight in kilograms (KG)
        /// </summary>
        public void TestMetricOverWeight()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.metre = 1.88;
            bmi.Kilogram = 101;

            //Act Stage
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 28.58;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.IndexBMI,2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Metric Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Centimetres(CM) and weight in kilograms (KG)
        ///Testing Underweight
        /// </summary>
        public void TestMetricUnderWeight()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.metre = 1.88;
            bmi.Kilogram = 50;

            //Act Stage
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 14.15;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.IndexBMI, 2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Metric Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Centimetres(CM) and weight in kilograms (KG)
        ///Testing Normal Range weight
        /// </summary>
        public void TestMetricNormal()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.metre = 1.88;
            bmi.Kilogram = 90;

            //Act Stage
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 25.46;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.IndexBMI, 2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Metric Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Centimetres(CM) and weight in kilograms (KG)
        ///Testing Obese Class 1
        /// </summary>
        public void TestMetricObeseI()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.metre = 1.88;
            bmi.Kilogram = 130;

            //Act Stage
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 36.78;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.IndexBMI, 2));
        }


        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Metric Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Centimetres(CM) and weight in kilograms (KG)
        ///Testing Obese Class 2
        /// </summary>
        public void TestMetricObeseII()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.metre = 1.88;
            bmi.Kilogram = 140;

            //Act Stage
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 39.61;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.IndexBMI, 2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Metric Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Centimetres(CM) and weight in kilograms (KG)
        ///Testing Obese Class 3
        /// </summary>
        public void TestMetricObeseIII()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.metre = 1.88;
            bmi.Kilogram = 150;

            //Act Stage
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 42.44;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.IndexBMI, 2));
        }



    }
}
